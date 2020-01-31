using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    private AudioSource clickSound;
    private bool besar;
    private int originalSibling;
    // Start is called before the first frame update
    void Start()
    {
        clickSound = GameObject.Find("Click").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ukuran(){
        if (besar != true){
            clickSound.Play();
            gameObject.transform.localScale = new Vector2(2, 2);
            for (int i = 0; i < transform.parent.childCount; i++)
            {
                if (i != gameObject.transform.GetSiblingIndex()){
                    transform.parent.GetChild(i).gameObject.SetActive(false);
                }
            }
            besar = true;
        }else{
            clickSound.Play();
            gameObject.transform.localScale = new Vector2(1, 1);
            for (int i = 0; i < transform.parent.childCount; i++)
            {
                if (i != gameObject.transform.GetSiblingIndex()){
                    transform.parent.GetChild(i).gameObject.SetActive(true);
                }
            }
            besar = false;
        }
    }
}
