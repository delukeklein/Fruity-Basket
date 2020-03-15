using FruityBasket.Environment.Highway;

using Unity.Entities;

using UnityEngine;

namespace FruityBasket.Basket.Authoring
{
    [DisallowMultipleComponent]
    [RequiresEntityConversion]
    public partial class BasketAuthoring : MonoBehaviour, IConvertGameObjectToEntity
    {
        [SerializeField] private float laneTranslationSpeed;

        [SerializeField] private Lane laneIndicator;

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            dstManager.AddComponent(entity, ComponentType.ReadWrite<Basket>());

            dstManager.AddComponentData(entity, new LaneIndicator { Value = laneIndicator });
            dstManager.AddComponentData(entity, new LaneTranslationSpeed { Value = laneTranslationSpeed });
        }
    }
}
