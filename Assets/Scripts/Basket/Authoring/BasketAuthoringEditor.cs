#if UNITY_EDITOR

using FruityBasket.Inspector;

using UnityEditor;

namespace FruityBasket.Basket.Authoring
{
    public partial class BasketAuthoring
    {
        [CanEditMultipleObjects]
        [CustomEditor(typeof(BasketAuthoring))]
        private class BasketAuthoringEditor : AuthoringEditor<BasketAuthoring>
        {
            private const string DataLabel = "Data";
            private const string LaneTranslationSpeedProperty = "laneTranslationSpeed";
            private const string LaneIndicatorProperty = "laneIndicator";

            private bool dataFoldout = true;

            protected override void OnDrawGUI()
            {
                DrawData();
            }

            private void DrawData()
            {
                DrawFoldout(DataLabel, ref dataFoldout, () =>
                {
                    DrawProperty(LaneIndicatorProperty);

                    DrawProperty(LaneTranslationSpeedProperty);
                });
            }
        }
    }
}

#endif
