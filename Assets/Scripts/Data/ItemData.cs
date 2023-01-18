using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName = "Project Data/Item/Miscellaneous")]
public abstract class ItemData : ScriptableObject
{
    [Header("Identification")]
    [SerializeField] public string idName = "Unnamed";
    [SerializeField] public Sprite idIcon;

    [Header("Settings")]
    [SerializeField][Min(0)] public int price;
    [SerializeField] public string description;

    //[Header("Art")]
    //[SerializeField] public GameObject model;
}
