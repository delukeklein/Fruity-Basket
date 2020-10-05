using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;

namespace FruityBasket.Scrolling.Systems
{
    [UpdateAfter(typeof(TranslateScrollerSystem))]
    [UpdateInGroup(typeof(ScrollerSystemGroup))]
    public class RelocateScrollerSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
                .ForEach((ref Translation translation, in RelocateScrollerDistance relocateDistance, in ScrollerTreshold treshold) =>
                {
                    if (translation.Value.z <= treshold.Value)
                    {
                        translation.Value.z += relocateDistance.Value;
                    }
                })
                .ScheduleParallel();
        }
    }
}