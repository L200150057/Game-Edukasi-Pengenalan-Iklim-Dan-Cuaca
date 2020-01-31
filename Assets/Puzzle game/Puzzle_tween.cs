using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puzzle_tween : MonoBehaviour
{
    public GameObject Complete;
    public GameObject gameOver;
    private GameObject petunjuk;
    private AudioSource click_sound;

    private bool stop;
    // Start is called before the first frame update
    void Start()
    {
        Complete = GameObject.Find("Win panel");
        gameOver = GameObject.Find("GameOver panel");
        petunjuk = GameObject.Find("Petunjuk");
        click_sound = GameObject.Find("Click").GetComponent<AudioSource>();
        
        gameOver.transform.localPosition = new Vector2(0, 0);
        gameOver.transform.localScale = new Vector2(0, 0);
        Complete.transform.localPosition = new Vector2(0, 0);
        Complete.transform.localScale = new Vector2(0, 0);
        petunjuk.transform.localPosition = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Countdown_puzzle.gameover == true){
            iTween.ScaleTo(gameOver, iTween.Hash("x", 0.95, "y", 0.95, "time", 1, "easeType", "easeOutBack"));
        } else if (Puzzle_control.Solved == true){
            StartCoroutine(jeda_win_panel());
        }
    }

    public void mulai(){
        click_sound.Play();
        petunjuk.transform.localScale = new Vector2(0, -720);
        Countdown_puzzle.mulai = true;
    }

    IEnumerator jeda_win_panel(){
        yield return new WaitForSeconds(2f);
        iTween.ScaleTo(Complete, iTween.Hash("x", 0.95, "y", 0.95, "time", 1, "easeType", "easeOutBack"));
    }
}
