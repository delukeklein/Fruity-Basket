using System;

using UnityEditor;

using UnityEngine;

namespace FruityBasket.Editor
{
    public abstract class AuthoringEditor<T> : UnityEditor.Editor where T : MonoBehaviour
    {
        protected T Target => (T)target;

        public sealed override void OnInspectorGUI()
        {
            serializedObject.Update();

            OnDrawGUI();

            serializedObject.ApplyModifiedProperties();
        }

        protected abstract void OnDrawGUI();

        protected void DrawFoldout(string label, ref bool foldout, Action propertiesCallback)
        {
            if (foldout = EditorGUILayout.BeginFoldoutHeaderGroup(foldout, label))
            {
                EditorGUI.indentLevel++;

                propertiesCallback.Invoke();

                EditorGUI.indentLevel--;
            }

            EditorGUILayout.EndFoldoutHeaderGroup();
        }

        protected void DrawProperty(string property)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty(property));
        }

        protected void DrawProperty(string property, bool condition)
        {
            if (condition)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty(property));
            }
        }

        protected T0 GetEnumProperty<T0>(string property) where T0 : Enum => (T0)(object)serializedObject.FindProperty(property).enumValueIndex;
        
    }
}