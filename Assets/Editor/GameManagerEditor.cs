using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(GameManager))]
public class GameManagerEditor : Editor
{
    private void OnEnable()
    {
        
    }

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();


        SerializedProperty m_InitialSpawnPoint = serializedObject.FindProperty("m_InitialSpawnPoint");
        EditorGUILayout.PropertyField(m_InitialSpawnPoint);
        SerializedProperty m_Player = serializedObject.FindProperty("m_Player");
        EditorGUILayout.PropertyField(m_Player);

        GUILayout.BeginHorizontal();

        SerializedProperty m_GreenDoor = serializedObject.FindProperty("m_GreenDoor");
        EditorGUILayout.PropertyField(m_GreenDoor);
        SerializedProperty greenSceneName = serializedObject.FindProperty("greenSceneName");
        
        string greenStr = greenSceneName.stringValue;
        greenStr = EditorGUILayout.TextField(greenStr, GUILayout.MinWidth(50), GUILayout.MaxWidth(125));
        greenSceneName.stringValue = greenStr;
        
        GUILayout.EndHorizontal();
        
        GUILayout.BeginHorizontal();

        SerializedProperty m_RedDoor = serializedObject.FindProperty("m_RedDoor");
        EditorGUILayout.PropertyField(m_RedDoor);
        SerializedProperty redSceneName = serializedObject.FindProperty("redSceneName");
        
        string redStr = redSceneName.stringValue;
        redStr = EditorGUILayout.TextField(redStr, GUILayout.MinWidth(50), GUILayout.MaxWidth(125));
        redSceneName.stringValue = redStr;
        
        GUILayout.EndHorizontal();
        
        GUILayout.BeginHorizontal();
        
        SerializedProperty m_BlueDoor = serializedObject.FindProperty("m_BlueDoor");
        EditorGUILayout.PropertyField(m_BlueDoor);
        SerializedProperty blueSceneName = serializedObject.FindProperty("blueSceneName");
        
        string blueStr = blueSceneName.stringValue;
        blueStr = EditorGUILayout.TextField(blueStr, GUILayout.MinWidth(50),
        GUILayout.MaxWidth(125));
        blueSceneName.stringValue = blueStr;

        GUILayout.EndHorizontal();
        
        GUILayout.BeginHorizontal();
        
        SerializedProperty m_YellowDoor = serializedObject.FindProperty("m_YellowDoor");
        EditorGUILayout.PropertyField(m_YellowDoor);
        SerializedProperty yellowSceneName = serializedObject.FindProperty("yellowSceneName");
        
        string yellowStr = yellowSceneName.stringValue;
        yellowStr = EditorGUILayout.TextField(yellowStr, GUILayout.MinWidth(50),
        GUILayout.MaxWidth(125));
        yellowSceneName.stringValue = yellowStr;
        
        GUILayout.EndHorizontal();


        SerializedProperty m_Cheater = serializedObject.FindProperty("m_Cheater");
        EditorGUILayout.PropertyField(m_Cheater);


        serializedObject.ApplyModifiedProperties();
    }

}
