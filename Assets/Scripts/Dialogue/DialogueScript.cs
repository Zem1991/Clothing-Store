using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Project Data/Dialogue/Script")]
public class DialogueScript : ScriptableObject
{
    [SerializeField] private List<DialogueLine> script;
    public List<DialogueLine> Script { get => script; private set => script = value; }
}
