using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class GenericUI<T> : MonoBehaviour
{
    [Header("GenericUI Awake")]
    [SerializeField] protected Image background;

    protected virtual void Awake()
    {
        background = GetComponent<Image>();
    }

    protected void Show()
    {
        gameObject.SetActive(true);
    }

    protected void Hide()
    {
        gameObject.SetActive(false);
    }

    public abstract void Refresh(T thing);
}
