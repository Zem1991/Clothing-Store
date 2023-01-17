using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractionUI : GenericUI<Interactable>
{
    [Header("InteractionUI Awake")]
    [SerializeField] private Image hotkeySprite;
    [SerializeField] private TMP_Text instructionText;

    protected override void Awake()
    {
        base.Awake();
        hotkeySprite = GetComponentInChildren<Image>();
        instructionText = GetComponentInChildren<TMP_Text>();
    }

    public override void Refresh(Interactable thing)
    {
        if (thing == null)
        {
            Hide();
            return;
        }

        instructionText.text = thing.GetInteractionText();
        Show();
    }
}
