using System;

using Unity.Entities;

namespace FruityBasket.Environment.Highway
{
    [Serializable]
    public struct LaneTranslationSpeed : IComponentData
    {
        public float Value;
    }
}