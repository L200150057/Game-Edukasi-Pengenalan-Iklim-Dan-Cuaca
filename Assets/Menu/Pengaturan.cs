using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pengaturan : MonoBehaviour
{
    Sprite on, off;

    void Start(){

        on = Resources.Load<Sprite>("audioOn");
        off = Resources.Load<Sprite>("audioOff");

        if (PlayerPrefs.GetInt("musicPrefs", 1) == 1){
            AudioListener.volume = 1;
            GameObject.Find("volume").GetComponent<Image>().sprite = on;
            GameObject.Find("volume").GetComponentInChildren<Text>().text = "Audio on";
        } else {
            AudioListener.volume = 0;
            GameObject.Find("volume").GetComponent<Image>().sprite = off;
            GameObject.Find("volume").GetComponentInChildren<Text>().text = "Audio off";
        }
    }

    public void yakinReset(bool jawaban){
        GameObject.Find("Click").GetComponent<AudioSource>().Play();
        if (jawaban == true){
            GameObject.Find("yakinReset?").transform.localScale = new Vector3(1, 1, 1);
        } else {
            GameObject.Find("yakinReset?").transform.localScale = new Vector3(0, 0, 0);
        }
    }

    public void resetGame(){
        GameObject.Find("Click").GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("unlockTebakgambar", 1);
        PlayerPrefs.SetInt("unlockPuzzlegame", 1);
        GameObject.Find("yakinReset?").transform.localScale = new Vector3(0, 0, 0);
    }

    public void yakinKeluar(bool jawaban){
        GameObject.Find("Click").GetComponent<AudioSource>().Play();
        if (jawaban == true){
            GameObject.Find("yakinKeluar?").transform.localScale = new Vector3(1, 1, 1);
        } else {
            GameObject.Find("yakinKeluar?").transform.localScale = new Vector3(0, 0, 0);
        }
    }

    public void Volume(){
        GameObject.Find("Click").GetComponent<AudioSource>().Play();
        if (PlayerPrefs.GetInt("musicPrefs") == 1){
            GameObject.Find("volume").GetComponent<Image>().sprite = off;
            GameObject.Find("volume").GetComponentInChildren<Text>().text = "Audio off";
            AudioListener.volume = 0;
            PlayerPrefs.SetInt("musicPrefs", 0);
        } else {
            GameObject.Find("volume").GetComponent<Image>().sprite = on;
            GameObject.Find("volume").GetComponentInChildren<Text>().text = "Audio on";
            AudioListener.volume = 1;
            PlayerPrefs.SetInt("musicPrefs", 1);
        }
    }

}
