using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericUI : MonoBehaviour
{
    protected void Show()
    {
        gameObject.SetActive(true);
    }

    protected void Hide()
    {
        gameObject.SetActive(false);
    }
}
