using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_handeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDrag;
    Vector3 startPosition;
    public static Transform startParent;

    public void OnBeginDrag (PointerEventData eventData){
        itemBeingDrag = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag (PointerEventData eventData){
        if (Input.touchCount > 1){
            return;
        }
        transform.position = Input.mousePosition;
        transform.SetParent(transform.root);
    }

    public void OnEndDrag (PointerEventData eventData){
        itemBeingDrag = null;
        if (transform.parent == startParent || transform.parent == transform.root)
        {
            transform.position = startPosition;
            transform.SetParent(startParent);
        }
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
