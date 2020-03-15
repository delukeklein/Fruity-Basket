using System;

using Unity.Entities;

namespace FruityBasket.Scrolling
{
    [Serializable]
    public struct ScrollerTreshold : IComponentData
    {
        public float Value;
    }
}