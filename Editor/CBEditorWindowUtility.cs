using UnityEditor;
using Cobilas.Collections;

namespace Cobilas.Unity.Editor.Utility {
    public static class CBEditorWindowUtility {
        public static EditorGUI.DisabledScope CreateDisabledScope(bool disabled)
            => new EditorGUI.DisabledScope(disabled);

        public static string ChangeToNon_ExistentName(string newName, string comp, string[] listName) {
            bool close = false;
            while (!close) {
                close = true;
                for (int I = 0; I < ArrayManipulation.ArrayLength(listName); I++)
                    if (listName[I] == newName) {
                        newName = $"{newName}{comp}";
                        close = false;
                    }
            }
            return newName;
        }
    }
}
