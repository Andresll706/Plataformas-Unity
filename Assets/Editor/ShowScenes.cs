using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShowScenes : EditorWindow
{
    [MenuItem("Window/Show Scenes")]
    public static void Init()
    {
        // Get existing open window or if none, make a new one:
        ShowScenes window = (ShowScenes)EditorWindow.GetWindow(typeof(ShowScenes));
        window.Show();
    }
    void OnGUI()
    {
        EditorBuildSettingsScene[] scenes = EditorBuildSettings.scenes;
        GUILayout.Label("Escenas", EditorStyles.boldLabel);
        foreach (var scene in scenes)
        {
            GUILayout.Label(scene.path, EditorStyles.boldLabel);
        }
    }

}
