using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jawaban : MonoBehaviour
{
    public GameObject wrong;
    public static bool Correct;
    private float lastClick = 0;
    // Start is called before the first frame update
    void Start()
    {
        Correct = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void benar(){
        Correct = true;
        Scene_management.unlockNextlevel_Puzzle();
    }

    public void salah(){
        if (lastClick > (Time.time - 1f)){
            return;
        }
        lastClick = Time.time;
        StartCoroutine(tungguSalah());
    }

    IEnumerator tungguSalah(){
        wrong.SetActive(true);
        GameObject.Find("Wrongsound").GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(2);
        wrong.SetActive(false);
    }
}
