using System;

using Unity.Entities;

namespace FruityBasket.Scrolling
{
    [Serializable]
    public struct RelocateScrollerDistance : IComponentData
    {
        public float Value;
    }
}
