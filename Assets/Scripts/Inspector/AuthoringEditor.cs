#if UNITY_EDITOR

using System;

using UnityEditor;

using UnityEngine;

namespace FruityBasket.Inspector
{
    public abstract class AuthoringEditor<T> : Editor where T : MonoBehaviour
    {
        protected T Target => (T)target;

        public sealed override void OnInspectorGUI()
        {
            serializedObject.Update();

            OnDrawGUI();

            serializedObject.ApplyModifiedProperties();
        }

        protected abstract void OnDrawGUI();

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
    }
}

#endif
