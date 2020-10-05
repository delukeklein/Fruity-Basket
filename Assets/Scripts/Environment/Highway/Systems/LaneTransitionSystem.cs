using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;

using UnityEngine;

namespace FruityBasket.Environment.Highway.Systems
{
    public class LaneTransitionSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            float deltaTime = Time.DeltaTime;

            Entities
                .ForEach((ref Translation translation, in LaneIndicator lane, in LaneTranslationSpeed speed) =>
                {
                    translation.Value.x = Mathf.MoveTowards(translation.Value.x, (float)lane.Value * 20f, speed.Value * deltaTime);
                })
                .ScheduleParallel();
        }
    }
}