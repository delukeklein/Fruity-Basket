using Unity.Entities;
using Unity.Transforms;

namespace FruityBasket.Scrolling.Systems
{
    [UpdateAfter(typeof(TransformSystemGroup))]
    public class ScrollerSystemGroup : ComponentSystemGroup
    {

    }
}