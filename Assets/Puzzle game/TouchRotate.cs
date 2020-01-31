using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TouchRotate : MonoBehaviour, IPointerDownHandler
{
    private AudioSource rotateSound;
    void Start(){
        rotateSound = GameObject.Find("Wut").GetComponent<AudioSource>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (!Puzzle_control.Solved){
            gameObject.GetComponent<RectTransform>().Rotate(0f, 0f, 90f);
            rotateSound.Play();
        }
    }
}