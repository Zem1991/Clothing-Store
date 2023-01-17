using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class GenericUI<T> : MonoBehaviour
{
    [Header("GenericUI Awake")]
    [SerializeField] private Image background;

    protected virtual void Awake()
    {
        List<Image> sprites = new List<Image>(GetComponentsInChildren<Image>());
        if (sprites.Count <= 0) return;
        background = sprites[0];
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
