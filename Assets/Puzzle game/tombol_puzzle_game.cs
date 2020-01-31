using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tombol_puzzle_game : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level_tropis"){
            for (int i = 1; i <= PlayerPrefs.GetInt("unlockPuzzlegame", 1); i++)
            {
                if (i < 4 ){
                    transform.Find("level_" + i).GetComponent<Button>().interactable = true;
                }
            }
        } else if (SceneManager.GetActiveScene().name == "Level_Sub_tropis") {
            for (int i = 4; i <= PlayerPrefs.GetInt("unlockPuzzlegame", 1); i++){
                if (i < 7){
                    transform.Find("level_" + i).GetComponent<Button>().interactable = true;
                }
            }
        } else if (SceneManager.GetActiveScene().name == "Level_Sedang") {
            for (int i = 7; i <= PlayerPrefs.GetInt("unlockPuzzlegame", 1); i++){
                if (i < 10){
                    transform.Find("level_" + i).GetComponent<Button>().interactable = true;
                }
            }
        } else if (SceneManager.GetActiveScene().name == "Level_Dingin") {
            for (int i = 10; i <= PlayerPrefs.GetInt("unlockPuzzlegame", 1); i++){
                if (i < 13){
                    transform.Find("level_" + i).GetComponent<Button>().interactable = true;
                }
            }
        } 
    }

    void Update()
    {
        
    }
}
