using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    private GameObject Background;
    private GameObject nextButtton;
    private GameObject backButton;   
    private int posisi;

    void Start(){
        posisi = 1;
        Background = GameObject.Find("Background");
        nextButtton = GameObject.Find("Next");
        backButton = GameObject.Find("Back");
    }

    public void Selanjutnya(){
        GameObject.Find("Click").GetComponent<AudioSource>().Play();
        iTween.MoveTo(GameObject.Find("Slide"+posisi), iTween.Hash("x", -1280, "y", 0, "time", 1.5, "easeType", "easeOutQuint", "islocal", true));
        iTween.MoveTo(GameObject.Find("Slide"+(posisi+1)), iTween.Hash("x", 0, "y", 0, "time", 1.5, "easeType", "easeOutQuint", "islocal", true));
        posisi = posisi+1;
    }

    public void Sebelumnya(){
        GameObject.Find("Click").GetComponent<AudioSource>().Play();
        iTween.MoveTo(GameObject.Find("Slide"+posisi), iTween.Hash("x", 1280, "y", 0, "time", 1.5, "easeType", "easeOutQuint", "islocal", true));
        iTween.MoveTo(GameObject.Find("Slide"+(posisi-1)), iTween.Hash("x", 0, "y", 0, "time", 1.5, "easeType", "easeOutQuint", "islocal", true));
        posisi = posisi-1;
    }

    void Update(){
        if (posisi == 1){
            backButton.SetActive(false);
        }
        else if (posisi == 7 && SceneManager.GetActiveScene().name == "Materi Cuaca"){
            nextButtton.SetActive(false);
        }
        else if (posisi == 9 && SceneManager.GetActiveScene().name == "Materi Iklim"){
            nextButtton.SetActive(false);
        }
        else{
            backButton.SetActive(true);
            nextButtton.SetActive(true);
        }
    }
}
