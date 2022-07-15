using System;
using UnityEditor;
using UnityEngine;

namespace Cobilas.Unity.Editor.Utility {
    public class CPropertyDrawer : PropertyDrawer {
        protected const float BlankSpace = 2f;
        protected float SingleLineHeight => EditorGUIUtility.singleLineHeight;
        protected float SingleRowHeightWithBlankSpace => SingleLineHeight + BlankSpace;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
            => base.OnGUI(position, property, label);

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
            => base.GetPropertyHeight(property, label);

        public override bool CanCacheInspectorGUI(SerializedProperty property)
            => base.CanCacheInspectorGUI(property);

        protected virtual Rect MoveDown(Rect rect)
            => MoveDown(rect, SingleLineHeight);

        protected virtual Rect MoveDownWithBlankSpace(Rect rect)
            => MoveDown(rect, SingleLineHeight + BlankSpace);

        protected virtual Rect MoveDown(Rect rect, SerializedProperty property)
            => MoveDown(rect, EditorGUI.GetPropertyHeight(property));

        [Obsolete("Use Rect:MoveDownInLine(Rect, int)")]
        protected virtual Rect MoveDown(Rect rect, int lines)
            => MoveDown(rect, SingleLineHeight * lines);

        protected virtual Rect MoveDownInLine(Rect rect, int lines)
            => MoveDown(rect, SingleLineHeight * lines);

        protected virtual Rect MoveDownInLineWithWhiteSpace(Rect rect, int lines)
            => MoveDown(rect, (SingleLineHeight * lines) + BlankSpace);

        protected virtual Rect MoveDown(Rect rect, float height) {
            rect.y += height;
            return rect;
        }

        protected EditorGUI.DisabledScope GetDisabledScope(bool disabled)
            => new EditorGUI.DisabledScope(disabled);

        protected void Print(object value)
            => Debug.Log(value);
    }
}
