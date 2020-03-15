using FruityBasket.Editor;

using UnityEditor;

namespace FruityBasket.Basket.Authoring.Editor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(BasketAuthoring))]
    public class BasketAuthoringEditor : AuthoringEditor<BasketAuthoring>
    {
        private const string DataLabel = "Data";
        private const string LaneIndicatorProperty = "laneIndicator";
        private const string LaneTranslationSpeedProperty = "laneTranslationSpeed";

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