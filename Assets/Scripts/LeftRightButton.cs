using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftRightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] float value;
    public void OnPointerDown(PointerEventData eventData)
    {
        CustomInput.SetHorizontalAxis(value);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        CustomInput.SetHorizontalAxis(0);
    }
}
