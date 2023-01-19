using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueUI : GenericUI<DialogueLine>
{
    [Header("DialogueUI Awake")]
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text messageText;
    [SerializeField] private RectTransform prompt;

    protected override void Awake()
    {
        base.Awake();
        List<TMP_Text> texts = new List<TMP_Text>(GetComponentsInChildren<TMP_Text>());
        nameText = texts[0];
        messageText = texts[1];
    }

    //public void Refresh(DialogueLine line, bool showPrompt)
    public override void Refresh(DialogueLine line)
    {
        if (line == null)
        {
            Hide();
            return;
        }

        nameText.text = line.Character.IdName;
        messageText.text = line.Text;
        //prompt.gameObject.SetActive(showPrompt);
        Show();
    }
}
