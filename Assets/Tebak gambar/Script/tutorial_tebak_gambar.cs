using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial_tebak_gambar : MonoBehaviour
{
    private GameObject instruksi1;
    private GameObject instruksi2;
    private GameObject instruksi3;
    private GameObject instruksi4;
    private GameObject instruksi5;
    private AudioSource click_sound;
    // Start is called before the first frame update
    void Start()
    {
        click_sound = GameObject.Find("Click").GetComponent<AudioSource>();

        instruksi1 = GameObject.Find("instruksi1");
        instruksi2 = GameObject.Find("instruksi2");
        instruksi3 = GameObject.Find("instruksi3");
        instruksi4 = GameObject.Find("instruksi4");
        instruksi5 = GameObject.Find("instruksi5");

        instruksi1.transform.localScale = new Vector2(0, 0);
        instruksi2.transform.localScale = new Vector2(0, 0);
        instruksi3.transform.localScale = new Vector2(0, 0);
        instruksi4.transform.localScale = new Vector2(0, 0);
        instruksi5.transform.localScale = new Vector2(0, 0);
        
        iTween.ScaleTo(instruksi1, iTween.Hash("x", -1, "y", 1, "time", 1, "easeType", "easeOutBack"));
    }

    public void petunjuk1(){
        click_sound.Play();
        GameObject.Find("Petunjuk1").SetActive(false);
        iTween.ScaleTo(instruksi2, iTween.Hash("x", 1, "y", -1, "time", 1, "easeType", "easeOutBack"));
    }

    public void petunjuk2(){
        click_sound.Play();
        GameObject.Find("Petunjuk2").SetActive(false);
        iTween.ScaleTo(instruksi3, iTween.Hash("x", 1, "y", -1, "time", 1, "easeType", "easeOutBack"));
    }

    public void petunjuk3(){
        click_sound.Play();
        GameObject.Find("Petunjuk3").SetActive(false);
        iTween.ScaleTo(instruksi4, iTween.Hash("x", -1, "y", 1, "time", 1, "easeType", "easeOutBack"));
    }

    public void petunjuk4(){
        click_sound.Play();
        GameObject.Find("Petunjuk4").SetActive(false);
        iTween.ScaleTo(instruksi5, iTween.Hash("x", 1, "y", 1, "time", 1, "easeType", "easeOutBack"));
    }
}
