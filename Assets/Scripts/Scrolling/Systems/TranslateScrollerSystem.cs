using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;

namespace FruityBasket.Scrolling.Systems
{
    [UpdateInGroup(typeof(ScrollerSystemGroup))]
    [UpdateBefore(typeof(RelocateScrollerSystem))]
    public class TranslateScrollerSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            float deltaTime = Time.DeltaTime;

            Entities
                .ForEach((ref Translation translation, in ScrollerDirection direction, in ScrollerSpeed speed) =>
                {
                    translation.Value.z += deltaTime * speed.Value * (int) direction.Value;
                })
                .ScheduleParallel();
        }
    }
}