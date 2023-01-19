using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class DialogueScript
{
    [Header("Setup")]
    private Queue<DialogueLineData> lines;
    private Player player;
    private float typingSpeed = 0.02F;

    [Header("Execution")]
    private DialogueLineData line;
    private AudioClip lineVoice;
    private string lineName;
    private string lineMessage;
    private bool isRunning;
    private bool isTyping;
    private IEnumerator typing;
    private SoundEffectPlayer soundEffectPlayer;

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
        lineVoice = line.Character.Voice;
        lineName = line.Character.IdName;
        lineMessage = "";

        typing = TypeMessage();
        player.StartCoroutine(typing);
    }

    private IEnumerator TypeMessage()
    {
        isTyping = true;
        char[] charArray = line.Text.ToCharArray();
        //lineMessage = "";
        foreach (char forChar in charArray)
        {
            PlayVoiceSound();
            lineMessage += forChar;
            yield return new WaitForSeconds(typingSpeed);
        }
        FinishTyping();
    }

    private void FinishTyping()
    {
        player.StopCoroutine(typing);
        PlayVoiceSound();
        lineMessage = line.Text;
        isTyping = false;
    }

    private void FinishDialogue()
    {
        isRunning = false;
        player.ClearDialogueScript();
        player.SetGameState(GameState.NORMAL);
    }

    private void PlayVoiceSound()
    {
        if (soundEffectPlayer != null && soundEffectPlayer.IsPlaying()) return;
        //if (soundEffectPlayer != null) soundEffectPlayer.Stop();
        soundEffectPlayer = new SoundEffectPlayer(lineVoice);
        soundEffectPlayer.Play();
    }
}
