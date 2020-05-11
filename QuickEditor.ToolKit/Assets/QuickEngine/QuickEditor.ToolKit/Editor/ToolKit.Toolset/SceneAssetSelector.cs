﻿#if UNITY_EDITOR

namespace QuickEditor.ToolKit
{
    using System.Reflection;
    using UnityEditor;
    using UnityEditor.SceneManagement;
    using UnityEngine;
    using UnityEngine.SceneManagement;

    [InitializeOnLoad]
    internal static class SceneAssetSelector
    {
        static SceneAssetSelector()
        {
            EditorApplication.hierarchyWindowItemOnGUI += OnGUI;
        }

        private static void OnGUI(int instanceID, Rect rect)
        {
            rect.x += rect.width - 20;
            rect.width = 16;

            var name = "eyeDropper.Large";
            var icon = EditorGUIUtility.IconContent(name);

            if (EditorUtility.InstanceIDToObject(instanceID) != null) return;
            if (!GUI.Button(rect, icon.image, GUIStyle.none)) return;

            var type = typeof(EditorSceneManager);
            var attr = BindingFlags.NonPublic | BindingFlags.Static;
            var handle = type.GetMethod("GetSceneByHandle", attr);
            var scene = (Scene)handle.Invoke(null, new object[] { instanceID });
            var path = scene.path;
            var sceneAsset = AssetDatabase.LoadAssetAtPath(path, typeof(SceneAsset));

            EditorGUIUtility.PingObject(sceneAsset);
        }
    }
}
#endif