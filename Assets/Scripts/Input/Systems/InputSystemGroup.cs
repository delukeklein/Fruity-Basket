using Unity.Entities;

namespace FruityBasket.Input.Systems
{
    //[UpdateAfter(typeof(InitializationSystemGroup))]
    [UpdateInGroup(typeof(InitializationSystemGroup))]
    public class InputSystemGroup : ComponentSystemGroup
    {

    }
}