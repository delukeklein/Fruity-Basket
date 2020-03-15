#if UNITY_EDITOR

using FruityBasket.Inspector;

using UnityEditor;

namespace FruityBasket.Scrolling.Authoring
{
    public partial class ScrollerAuthoring
    {
        [CanEditMultipleObjects]
        [CustomEditor(typeof(ScrollerAuthoring))]
        private class ScrollerAuthoringEditor : AuthoringEditor<ScrollerAuthoring>
        {
            private const string DataLabel = "Data";
            private const string SettingsLabel = "Settings";

            private const string SpeedProperty = "speed";
            private const string TresholdProperty = "treshold";
            private const string RelocateDistanceProperty = "relocateDistance";
            private const string DirectionProperty = "direction";
            private const string TresholdActionProperty = "tresholdAction";

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
                    DrawProperty(SpeedProperty);

                    DrawProperty(TresholdProperty);

                    DrawProperty(RelocateDistanceProperty, Target.tresholdAction == TresholdAction.Relocate);                

                    DrawProperty(DirectionProperty);
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
}

#endif