#if PLATFORM_STANDALONE_WIN && UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.Diagnostics;

namespace Cobilas.Unity.Editor.Utility {
    public static class UnityOpenFolders
    {
        [MenuItem("Tools/Cobilas/Unity open folders/Assets path")]
        private static void AssetsPath()
            => OpenFolder(Application.dataPath);

        [MenuItem("Tools/Cobilas/Unity open folders/Console log path")]
        private static void ConsoleLogPath()
            => OpenFolder(Application.consoleLogPath);

        [MenuItem("Tools/Cobilas/Unity open folders/Persistent path")]
        private static void PersistentDataPath()
            => OpenFolder(Application.persistentDataPath);

        [MenuItem("Tools/Cobilas/Unity open folders/Temporary cache path")]
        private static void TemporaryCachePath()
            => OpenFolder(Application.temporaryCachePath);

        [MenuItem("Tools/Cobilas/Unity open folders/Editor contents path")]
        private static void EditorContentsPath()
            => OpenFolder(EditorApplication.applicationContentsPath);

        private static void OpenFolder(string folderPath) {
            MonoBehaviour.print(folderPath);
            Process.Start("explorer.exe", folderPath.Replace('/', '\\')).Dispose();
        }
    }
}
#endif