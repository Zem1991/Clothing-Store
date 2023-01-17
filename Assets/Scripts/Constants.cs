using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants
{
    [Header("Physics")]
    public static readonly LayerMask interactableMask = LayerMask.GetMask("Interactable");
    public static readonly LayerMask characterMask = LayerMask.GetMask("Character");
}