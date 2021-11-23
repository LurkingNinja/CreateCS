using System;
using UnityEditor;
using UnityEngine;

namespace LurkingNinja.CreateCs.Editor
{
    public static partial class MenuItems
    {
        private const string BASE_MENU = "Assets/Create C#/";
        private const string UNITY_CSHARP_MENU = BASE_MENU + "Unity's C# Script %&o";
        private const string CUSTOM_CSHARP_MENU = BASE_MENU + "C# Script %&n";
		private const string DEFAULT_BEHAVIOR_FILENAME = "NewBehaviorScript.cs";
        
        private static readonly string _baseTemplatePath = Application.dataPath
                + "/Plugins/LurkingNinja/CreateCs/Editor/ScriptTemplates/";
        private static readonly string _unityCsTemplatePath = EditorApplication.applicationContentsPath +
                "/Resources/ScriptTemplates/81-C# Script-NewBehaviourScript.cs.txt";
        
        private static readonly Type _pwuType = typeof(ProjectWindowUtil);
        
        [MenuItem(UNITY_CSHARP_MENU, false, 11)]
        public static void CreateUnityCsMenu()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                _unityCsTemplatePath,
				DEFAULT_BEHAVIOR_FILENAME);
        }

        [MenuItem(CUSTOM_CSHARP_MENU, false, 22)]
        public static void CreateCsMenu()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                _baseTemplatePath + "NewBehaviourScript.cs.txt",
                DEFAULT_BEHAVIOR_FILENAME);
        }
    }
}
