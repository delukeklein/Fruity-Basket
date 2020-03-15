using Unity.Entities;

using UnityEngine;

namespace FruityBasket.Scrolling.Authoring
{
    [AddComponentMenu("Fruity Basket/Scrolling/Scroller Authoring")]
    [DisallowMultipleComponent]
    [RequiresEntityConversion]
    public partial class ScrollerAuthoring : MonoBehaviour, IConvertGameObjectToEntity
    {
        [SerializeField] private float speed;
        [SerializeField] private float treshold;
        [SerializeField] private float relocateDistance;

        [SerializeField] private Direction direction = Direction.Backward;

        [SerializeField] private TresholdAction tresholdAction;

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            dstManager.AddComponentData(entity, new ScrollerSpeed { Value = speed });
            dstManager.AddComponentData(entity, new ScrollerDirection { Value = direction });
            dstManager.AddComponentData(entity, new ScrollerTreshold { Value = treshold });

            if (tresholdAction == TresholdAction.Relocate)
            {
                dstManager.AddComponentData(entity, new RelocateScrollerDistance { Value = relocateDistance });
            }
        }

        private enum TresholdAction
        {
            Destroy,
            Relocate
        }
    }
}