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

        protected void DrawFoldout(string label, ref bool foldout, Action onFoldout)
        {
            if (foldout = EditorGUILayout.Foldout(foldout, label, !foldout, EditorStyles.foldoutHeader))
            {
                EditorGUI.indentLevel++;

                onFoldout.Invoke();

                EditorGUI.indentLevel--;
            }
        }
    }
}

#endif
