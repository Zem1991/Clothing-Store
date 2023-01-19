using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueUI : GenericUI<DialogueScript>
{
    [Header("DialogueUI References")]
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text messageText;
    [SerializeField] private RectTransform prompt;

    protected override void Awake()
    {
        base.Awake();
        //List<TMP_Text> texts = new List<TMP_Text>(GetComponentsInChildren<TMP_Text>());
        //nameText = texts[0];
        //messageText = texts[1];
    }

    //public void Refresh(DialogueLine line, bool showPrompt)
    public override void Refresh(DialogueScript thing)
    {
        if (thing == null)
        {
            Hide();
            return;
        }

        nameText.text = thing.GetName();
        messageText.text = thing.GetMessage();
        //prompt.gameObject.SetActive(showPrompt);
        Show();
    }
}
