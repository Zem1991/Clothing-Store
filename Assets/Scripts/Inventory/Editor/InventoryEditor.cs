//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor;
//using UnityEngine;

//[CustomPropertyDrawer(typeof(Inventory))]
//public class InventoryEditor : PropertyDrawer
//{
//    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
//    {
//        EditorGUI.BeginProperty(position, label, property);
//        Rect value = new Rect(position.x, position.y, position.width, position.height * 1F);
//        GUI.Label(value, GetDescription(property));
//        EditorGUI.EndProperty();
//    }

//    private string GetDescription(SerializedProperty property)
//    {
//        string result = string.Empty;
//        //result += $"EQUIPPED\n";
//        //result += $"Head: {property.FindPropertyRelative("head.current?.idName")}\n";
//        result += $"Torso: {property.FindPropertyRelative("torso.current?.idName")}\n";
//        //result += $"Legs: {property.FindPropertyRelative("legs.current?.idName")}\n";
//        //result += $"Feet: {property.FindPropertyRelative("feet.current?.idName")}\n";
//        return result;
//    }
//}

