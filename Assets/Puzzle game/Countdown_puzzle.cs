using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdown_puzzle : MonoBehaviour
{
    private float timeLeft;
    public static bool gameover;
    public static bool mulai;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        switch (SceneManager.GetActiveScene().name){
            
            case "Level_1":
            case "Level_4":
            case "Level_7":
            case "Level_10":
                timeLeft = 40f;
            break;

            case "Level_2":
            case "Level_5":
            case "Level_8":
            case "Level_11":
                timeLeft = 80f;
            break;

            case "Level_3":
            case "Level_6":
            case "Level_9":
            case "Level_12":
                timeLeft = 120f;
            break;
        }

        gameover = false;
        mulai = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover == false && Puzzle_control.Solved == false && mulai == true){
            timeLeft -= Time.deltaTime;
            text.text = "Waktu terisisa: " + Mathf.Round(timeLeft);
            if (timeLeft < 0){
                gameover = true;
            }
        }
    }
}
