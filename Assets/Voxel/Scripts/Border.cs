using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Border : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image borde;

    private Color colorOriginal;

    void Start()
    {
        colorOriginal = borde.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        borde.color = Color.white;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        borde.color = colorOriginal;
    }
}
