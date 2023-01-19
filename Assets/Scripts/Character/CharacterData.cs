using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Project Data/Character/Any")]
public class CharacterData : ScriptableObject
{
    [Header("Identification")]
    [SerializeField] private string idName = "Unnamed";
    public string IdName { get => idName; private set => idName = value; }

    [Header("Dialogue")]
    [SerializeField] private Sprite face;
    [SerializeField] private AudioClip voice;
    public Sprite Face { get => face; private set => face = value; }
    public AudioClip Voice { get => voice; private set => voice = value; }
}
