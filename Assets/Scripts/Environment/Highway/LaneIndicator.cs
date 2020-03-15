using System;

using Unity.Entities;

namespace FruityBasket.Environment.Highway 
{
    [Serializable]
    public struct LaneIndicator : IComponentData
    {
        public Lane Value;
    }

    public enum Lane
    {
        Left = -1,
        Middle = 0,
        Right = 1
    }
}