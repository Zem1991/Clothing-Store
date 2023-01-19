using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Project Data/Dialogue/Script")]
public class DialogueScriptData : ScriptableObject
{
    [SerializeField] private List<DialogueLineData> lines;
    public List<DialogueLineData> Lines { get => lines; private set => lines = value; }
}
