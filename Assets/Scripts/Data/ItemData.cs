using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName = "Project Data/Item/Miscellaneous")]
public abstract class ItemData : ScriptableObject
{
    [Header("Identification")]
    [SerializeField] private string idName = "Unnamed";
    [SerializeField] private Sprite idIcon;
    public string IdName { get => idName; private set => idName = value; }
    public Sprite IdIcon { get => idIcon; private set => idIcon = value; }

    [Header("Settings")]
    [SerializeField][Min(0)] private int price;
    [SerializeField] private string description;
    public int Price { get => price; private set => price = value; }
    public string Description { get => description; private set => description = value; }

    [Header("Art")]
    public ItemDataMonobehavior ItemDataMonobehavior;
    //[SerializeField] private AnimatorController animatorController;
    //public AnimatorController AnimatorController { get => animatorController; private set => animatorController = value; }

    public abstract ItemType GetItemType();
}
