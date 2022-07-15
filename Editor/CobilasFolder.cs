using System.IO;
using UnityEditor;
using UnityEngine;

namespace Cobilas.Unity.Editor.Utility {
    public static class CobilasFolder {

        public static string RootFolder => Path.GetDirectoryName(Application.dataPath);

        [MenuItem("Assets/Create/Cobilas folder/Utility folder")]
        private static void InitUtilityFolder()
            => CriateFolder("Utility");

        [MenuItem("Assets/Create/Cobilas folder/Resources folder")]
        private static void InitResourcesFolder()
            => CriateFolder("Resources");

        [MenuItem("Assets/Create/Cobilas folder/Editor folder")]
        private static void InitEditorFolder()
            => CriateFolder("Editor");

        [MenuItem("Assets/Create/Cobilas folder/Streaming assets folder")]
        private static void InitStreamingAssetsFolder()
            => CriateFolder("StreamingAssets");

        [MenuItem("Assets/Create/Cobilas folder/ScriptTDS folder")]
        private static void InitScriptTDSFolder()
            => CriateFolder("ScriptTDS");

        [MenuItem("Assets/Create/Cobilas folder/Script folder")]
        private static void InitScriptFolder()
            => CriateFolder("Script");

        [MenuItem("Assets/Create/Cobilas folder/Prefabs folder")]
        private static void InitPrefabsFolder()
            => CriateFolder("Prefabs");

        [MenuItem("Assets/Create/Cobilas folder/Textures folder")]
        private static void InitTexturesFolder()
            => CriateFolder("Textures");

        [MenuItem("Assets/Create/Cobilas folder/Dlls folder")]
        private static void InitDllsFolder()
            => CriateFolder("Dlls");

        [MenuItem("Assets/Create/Cobilas folder/Classes auxiliares folder")]
        private static void InitClassesAuxiliaresFolder()
            => CriateFolder("Classes auxiliares");

        [MenuItem("Assets/Create/Cobilas folder/Atributos folder")]
        private static void InitAtributosFolder()
            => CriateFolder("Atributos");

        [MenuItem("Assets/Create/Cobilas folder/Interfaces folder")]
        private static void InitInterfacesFolder()
            => CriateFolder("Interfaces");

        [MenuItem("Assets/Create/Cobilas folder/Extenções folder")]
        private static void InitExtencoesFolder()
            => CriateFolder("Extenções");

        [MenuItem("Assets/Create/Cobilas folder/Shaders folder")]
        private static void InitShadersFolder()
            => CriateFolder("Shaders");

        [MenuItem("Assets/Create/Cobilas folder/Materiais folder")]
        private static void InitMateriaisFolder()
            => CriateFolder("Materiais");

        [MenuItem("Assets/Create/Cobilas folder/Unity folders")]
        private static void InitUnityFolders() {
            InitResourcesFolder();
            InitEditorFolder();
            InitStreamingAssetsFolder();
        }

        private static void CriateFolder(string nameFolder) {
            string assetfolderpath = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (AssetDatabase.IsValidFolder(assetfolderpath))
                AssetDatabase.CreateFolder(assetfolderpath, nameFolder);
            else AssetDatabase.CreateFolder("Assets", nameFolder);
            AssetDatabase.Refresh();
        }
    }
}