using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joybutton : MonoBehaviour,IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    protected bool Preseed;

    void Start()
    {

    }

    void Update()
    {

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Preseed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Preseed = false;

    }

}
