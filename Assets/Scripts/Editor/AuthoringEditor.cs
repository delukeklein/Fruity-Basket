using System;

using UnityEditor;

using UnityEngine;

namespace FruityBasket.Editor
{
    public delegate void DrawCallback();

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

        protected void DrawFoldout(string label, ref bool foldout, DrawCallback drawCallback)
        {
            if (foldout = EditorGUILayout.BeginFoldoutHeaderGroup(foldout, label))
            {
                EditorGUI.indentLevel++;

                drawCallback.Invoke();

                EditorGUI.indentLevel--;
            }

            EditorGUILayout.EndFoldoutHeaderGroup();
        }

        protected void DrawProperty(string property)
        {
            EditorGUILayout.PropertyField(FindProperty(property));
        }

        protected void DrawProperty(string property, bool condition)
        {
            if (condition)
            {
                EditorGUILayout.PropertyField(FindProperty(property));
            }
        }

        protected TEnum GetEnumProperty<TEnum>(string property) where TEnum : Enum => (TEnum)(object)FindProperty(property).intValue;

        private SerializedProperty FindProperty(string property) => serializedObject.FindProperty(property);

    }
}