using FruityBasket.Editor;

using UnityEditor;

using TresholdAction = FruityBasket.Scrolling.Authoring.ScrollerAuthoring.TresholdAction;

namespace FruityBasket.Scrolling.Authoring
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(ScrollerAuthoring))]
    public class ScrollerAuthoringEditor : AuthoringEditor<ScrollerAuthoring>
    {
        private const string DataLabel = "Data";
        private const string DirectionProperty = "direction";
        private const string RelocateDistanceProperty = "relocateDistance";
        private const string SettingsLabel = "Settings";
        private const string SpeedProperty = "speed";
        private const string TresholdActionProperty = "tresholdAction";
        private const string TresholdProperty = "treshold";

        private bool dataFoldout = true;
        private bool settingsFoldout = true;

        protected override void OnDrawGUI()
        {
            DrawData();

            DrawSettings();
        }

        private void DrawData()
        {
            DrawFoldout(DataLabel, ref dataFoldout, () =>
            {
                DrawProperty(DirectionProperty);

                DrawProperty(RelocateDistanceProperty, GetEnumProperty<TresholdAction>(RelocateDistanceProperty) == TresholdAction.Relocate);

                DrawProperty(SpeedProperty);

                DrawProperty(TresholdProperty);
            });
        }

        private void DrawSettings()
        {
            DrawFoldout(SettingsLabel, ref settingsFoldout, () =>
            {
                DrawProperty(TresholdActionProperty);
            });
        }
    }
}