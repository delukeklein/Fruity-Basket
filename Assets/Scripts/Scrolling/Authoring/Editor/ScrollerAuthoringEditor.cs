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
        private const string SettingsLabel = "Settings";

        private const string DirectionProperty = "direction";
        private const string RelocateDistanceProperty = "relocateDistance";
        private const string SpeedProperty = "speed";
        private const string TresholdProperty = "treshold";
        private const string TresholdActionProperty = "tresholdAction";

        private bool dataFoldout = true;
        private bool settingsFoldout = true;

        protected override void OnDrawGUI()
        {
            DrawDataProperties();

            DrawSettingsProperties();
        }

        private void DrawDataProperties()
        {
            DrawFoldout(DataLabel, ref dataFoldout, () =>
            {
                DrawProperty(DirectionProperty);

                DrawProperty(RelocateDistanceProperty, GetEnumProperty<TresholdAction>(TresholdActionProperty) == TresholdAction.Relocate);

                DrawProperty(SpeedProperty);

                DrawProperty(TresholdProperty);
            });
        }

        private void DrawSettingsProperties()
        {
            DrawFoldout(SettingsLabel, ref settingsFoldout, () =>
            {
                DrawProperty(TresholdActionProperty);
            });
        }
    }
}