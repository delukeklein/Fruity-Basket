﻿using FruityBasket.Editor;

using FruityBasket.Environment.Highway;

using UnityEditor;

using UnityEngine;

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

            UpdateBasketPosition();
        }

        private void DrawData()
        {
            DrawFoldout(DataLabel, ref dataFoldout, () =>
            {
                DrawProperty(LaneIndicatorProperty);

                DrawProperty(LaneTranslationSpeedProperty);
            });
        }

        private void UpdateBasketPosition()
        {
            var position = Target.transform.position;

            position.x = (int)GetEnumProperty<Lane>(LaneIndicatorProperty) * 20f;

            Target.transform.position = position;
        }
    }
}