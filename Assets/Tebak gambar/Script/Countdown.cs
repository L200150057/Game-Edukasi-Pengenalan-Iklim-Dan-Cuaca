using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public static bool gameover;
    private float timeLeft;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        gameover = false;

        switch (SceneManager.GetActiveScene().name){
            
            case "Level_1":
            case "Level_2":
                timeLeft = 50f;
            break;

            case "Level_3":
                timeLeft = 60f;
            break;

            case "Level_4":
            case "Level_5":
            case "Level_6":
                timeLeft = 70f;
            break;

            case "Level_7":
            case "Level_8":
                timeLeft = 90f;
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover != true && Win.menang != true){
            timeLeft -= Time.deltaTime;
            text.text = "Waktu terisisa: " + Mathf.Round(timeLeft);
            if (timeLeft < 0){
                gameover = true;
            }   
        }
    }
}
