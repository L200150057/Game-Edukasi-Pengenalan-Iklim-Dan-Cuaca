using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tween : MonoBehaviour
{
    private GameObject Complete;
    private GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        Complete = GameObject.Find("Win panel");
        gameOver = GameObject.Find("GameOver panel");

        Complete.GetComponent<Transform>().localScale = new Vector2(0, 0);
        Complete.GetComponent<Transform>().localPosition = new Vector2(0, 0);

        gameOver.GetComponent<Transform>().localScale = new Vector2(0, 0);
        gameOver.GetComponent<Transform>().localPosition = new Vector2(0, 0);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Countdown.gameover == true){
            hasil(gameOver);
        } else if (Win.menang == true){
            hasil(Complete);
        }
    }

    public void hasil(GameObject parameter){
        iTween.ScaleTo(parameter, iTween.Hash("x", 0.95, "y", 0.95, "time", 1, "easeType", "easeOutBack"));
    }

    public void mulai(){
        GameObject.Find("Click").GetComponent<AudioSource>().Play();
        GameObject.Find("panelPetunjuk").SetActive(false);
    }
}
