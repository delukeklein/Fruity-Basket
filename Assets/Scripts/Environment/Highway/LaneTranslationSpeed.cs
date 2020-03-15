using System;

using Unity.Entities;

namespace FruityBasket.Environment.Highway
{
    [Serializable]
    [GenerateAuthoringComponent]
    public struct LaneTranslationSpeed : IComponentData
    {
        public float Value;
    }
}
