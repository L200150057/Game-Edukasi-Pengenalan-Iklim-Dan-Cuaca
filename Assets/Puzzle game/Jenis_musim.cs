using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jenis_musim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("unlockPuzzlegame", 1) >= 4){
            transform.GetChild(1).GetComponent<Button>().interactable = true;
            transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).GetChild(1).gameObject.SetActive(false);
            if (PlayerPrefs.GetInt("unlockPuzzlegame", 1) >= 7){
                transform.GetChild(2).GetComponent<Button>().interactable = true;
                transform.GetChild(2).GetChild(0).gameObject.SetActive(true);
                transform.GetChild(2).GetChild(1).gameObject.SetActive(false);
                if (PlayerPrefs.GetInt("unlockPuzzlegame", 1) >= 10){
                    transform.GetChild(3).GetComponent<Button>().interactable = true;
                    transform.GetChild(3).GetChild(0).gameObject.SetActive(true);
                    transform.GetChild(3).GetChild(1).gameObject.SetActive(false);
                }
            }
        }
    }
}
