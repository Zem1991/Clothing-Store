using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mannequin : MonoBehaviour, Interactable
{
    [Header("Settings")]
    [SerializeField] private ItemData item;

    public string GetInteractionText()
    {
        return $"Buy {item.IdName} for ${item.Price}";
    }

    public Vector3 GetInteractionPosition()
    {
        return transform.position;
    }

    public bool Interact(Player player)
    {
        MoneyTransactionHandler handler = new(player);
        return handler.BuyItem(item);
    }
}
