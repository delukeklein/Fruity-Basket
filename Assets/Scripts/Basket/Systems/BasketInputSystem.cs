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
            int axis = (Keyboard.current.aKey.wasPressedThisFrame ? -1 : 0) + 
                       (Keyboard.current.dKey.wasPressedThisFrame ? 1 : 0);

            Entities
                .WithAll<Basket>()
                .ForEach((ref LaneIndicator lane) =>
                {
                    lane.Value = (Lane)clamp((int)lane.Value + axis, (int)Lane.Left, (int)Lane.Right);
                })
                .ScheduleParallel();
        }
    }
}