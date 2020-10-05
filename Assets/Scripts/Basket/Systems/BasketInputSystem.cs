using FruityBasket.Environment.Highway;
using FruityBasket.Input.Systems;

using Unity.Entities;
using Unity.Jobs;

using UnityEngine.InputSystem;

using static Unity.Mathematics.math;

namespace FruityBasket.Basket.Systems
{
    [UpdateInGroup(typeof(InputSystemGroup))]
    public class BasketInputSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var horizontal = (Keyboard.current.aKey.wasPressedThisFrame ? -1 : 0) +
                             (Keyboard.current.dKey.wasPressedThisFrame ? 1 : 0);

            Entities
                .WithAll<Basket>()
                .ForEach((ref LaneIndicator lane) =>
                {
                    lane.Value = (Lane)clamp(horizontal + (int)lane.Value, (int)Lane.Left, (int)Lane.Right);
                })
                .ScheduleParallel();
        }
    }
}