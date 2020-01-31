using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameoverSkor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<TMPro.TMP_Text>().text = "Skor Anda: "+PlayerPrefs.GetInt("skor");
        PlayerPrefs.SetInt("skor", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
