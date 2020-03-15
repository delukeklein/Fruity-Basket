using Unity.Entities;

namespace FruityBasket.Scrolling
{
    public struct ScrollerDirection : IComponentData
    {
        public Direction Value;
    }

    public enum Direction
    {
        Backward = -1,
        Forward = 1
    }
}