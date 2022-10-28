using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Cell))]
public class CellPropertyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) 
    {
        EditorGUI.BeginProperty(position, label, property);
        
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        var filaRect = new Rect(position.x, position.y, 30, 15);
        var columnaRect = new Rect(position.x, position.y + 25, 50, 15);

        EditorGUI.PropertyField(filaRect, property.FindPropertyRelative("_fila"), GUIContent.none);
        EditorGUI.PropertyField(columnaRect, property.FindPropertyRelative("_columna"), GUIContent.none);
        
        EditorGUI.indentLevel = indent;
        
        EditorGUI.EndProperty();
    }


    public override float GetPropertyHeight(SerializedProperty prop, GUIContent label)
    {
        return 40.0f;
    }
}
