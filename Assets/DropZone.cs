﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop to " + gameObject.name);

        //object we are draggin is eventData.pointerDrag
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null) {
            d.parentToReturnTo = this.transform;
        }
    }

    public void OnPointerEnter(PointerEventData eventData) {
        Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData) {
        Debug.Log("OnPointerExit");
    }
}
