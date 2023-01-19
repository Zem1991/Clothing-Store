using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class DialogueScript
{
    [Header("Setup")]
    private Queue<DialogueLineData> lines;
    private Player player;

    [Header("Execution")]
    private DialogueLineData line;
    private string lineName;
    private string lineMessage;
    private bool isRunning;
    private bool isTyping;
    private IEnumerator typing;

    public DialogueScript(Player player, DialogueScriptData dialogueScriptData)
    {
        List<DialogueLineData> linesList = dialogueScriptData.Lines;
        lines = new(linesList);
        this.player = player;
    }

    public string GetName()
    {
        return lineName;
    }

    public string GetMessage()
    {
        return lineMessage;
    }

    public void StartDialogue()
    {
        if (isRunning) return;
        isRunning = true;
        player.SetGameState(GameState.DIALOGUE);
        Interaction();
    }

    public void Interaction()
    {
        if (isTyping) FinishTyping();
        else NextLine();
    }

    private void NextLine()
    {
        if (lines.Count <= 0)
        {
            FinishDialogue();
            return;
        }

        line = lines.Dequeue();
        lineName = line.Character.IdName;
        lineMessage = "";

        typing = TypeMessage();
        player.StartCoroutine(typing);
    }

    private IEnumerator TypeMessage()
    {
        isTyping = true;
        char[] charArray = line.Text.ToCharArray();
        lineMessage = "";
        foreach (char forChar in charArray)
        {
            lineMessage += forChar;
            yield return null;
        }
        FinishTyping();
    }

    private void FinishTyping()
    {
        player.StopCoroutine(typing);
        lineMessage = line.Text;
        isTyping = false;
    }

    private void FinishDialogue()
    {
        isRunning = false;
        player.ClearDialogueScript();
        player.SetGameState(GameState.NORMAL);
    }
}
