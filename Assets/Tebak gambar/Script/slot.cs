using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class slot : MonoBehaviour, IDropHandler
{
    private AudioSource click;

    public void Start(){
        click = GameObject.Find("Wut").GetComponent<AudioSource>();
    }

    public GameObject item {
        get {
            if (transform.childCount > 0){
                return transform.GetChild (0).gameObject;
            }
            return null;
        }
    }
    public void OnDrop(PointerEventData eventdata)
    {
        click.Play();
        if (!item){
            Drag_handeler.itemBeingDrag.transform.SetParent(transform);
        } else {
            Transform tukar = Drag_handeler.startParent;
            Drag_handeler.itemBeingDrag.transform.SetParent(transform);
            item.transform.SetParent(tukar);
        }
    }
}
