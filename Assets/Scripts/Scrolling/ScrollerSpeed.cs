using System;

using Unity.Entities;

namespace FruityBasket.Scrolling
{
    [Serializable]
    public struct ScrollerSpeed : IComponentData
    {
        public float Value;
    }
}