using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tombol_tebak_gambar : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < PlayerPrefs.GetInt("unlockTebakgambar", 1); i++)
        {
            gameObject.transform.GetChild(i).GetComponent<Button>().interactable = true;
        } 
    }

    void Update()
    {
        
    }
}