﻿using Unity.Entities;
using Unity.Transforms;

namespace FruityBasket.Scrolling.Systems
{
    [UpdateAfter(typeof(TranslateScrollerSystem))]
    [UpdateInGroup(typeof(ScrollerSystemGroup))]
    public class DestroyScrollerSystem : SystemBase
    {
        private EntityCommandBufferSystem commandBufferSystem;

        protected override void OnCreate()
        {
            commandBufferSystem = World.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
        }

        protected override void OnUpdate()
        {
            var commandBuffer = commandBufferSystem.CreateCommandBuffer().ToConcurrent();

            Entities
                .WithNone<RelocateScrollerDistance>()
                .WithAll<ScrollerDirection, ScrollerSpeed>()
                .ForEach((Entity entity, int entityInQueryIndex, in Translation translation, in ScrollerTreshold treshold) =>
                {
                    if (translation.Value.z <= treshold.Value)
                    {
                        commandBuffer.DestroyEntity(entityInQueryIndex, entity);
                    }
                })
                .ScheduleParallel();

            commandBufferSystem.AddJobHandleForProducer(Dependency);
        }
    }
}