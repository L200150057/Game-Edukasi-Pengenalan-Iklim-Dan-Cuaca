using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Waktu : MonoBehaviour
{
    public static bool selesai;
    // Start is called before the first frame update
    void Start()
    {
        selesai = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (selesai == false){
            kuisController.targetTime -= Time.deltaTime;
            GameObject.Find("Waktu").GetComponent<Text>().text = "Waktu tersisa: "+kuisController.targetTime.ToString("f0");
            if (kuisController.targetTime < 0){
                PlayerPrefs.SetInt("skor", kuisController.jumlahSkor);
                SceneManager.LoadScene("Kuis/GameOver");
                selesai = true;
            }
        }
    }
}
