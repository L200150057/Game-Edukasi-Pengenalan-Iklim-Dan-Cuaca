using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Koreksi : MonoBehaviour
{
    public bool jalankanSekali;
    void Start(){
        jalankanSekali = false;
    }
    public void benar(){
        if (kuisController.targetTime > 0 && jalankanSekali == false){
            jalankanSekali = true;
            kuisController.jumlahSkor = kuisController.jumlahSkor + 10;
            GameObject.Find("Winsound").GetComponent<AudioSource>().Play();
            StartCoroutine(koreksiJawaban("Benar"));
        }
    }

    public void salah(){
        if (kuisController.targetTime > 0 && jalankanSekali == false){
            jalankanSekali = true;
            GameObject.Find("Wrongsound").GetComponent<AudioSource>().Play();
            StartCoroutine(koreksiJawaban("Salah"));
        }
    }

    public void nextQuestion(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ulangi(){
        GameObject.Find("Click").GetComponent<AudioSource>().Play();
        kuisController.buatList();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator koreksiJawaban (string jawaban){
        GameObject.Find(jawaban).transform.localScale = new Vector3(1, 1, 1);
        yield return new WaitForSeconds(2);
        GameObject.Find(jawaban).transform.localScale = new Vector3(0, 0, 0);
        if (kuisController.noSoal.Count == 0){
            iTween.MoveTo(GameObject.Find("winPanel"), iTween.Hash("x", 0, "y", 0, "time", 1, "easeType", "easeOutBack", "islocal", true));
            GameObject.Find("Skor").GetComponent<TMPro.TMP_Text>().text = "Nilai anda: "+kuisController.jumlahSkor;
            Waktu.selesai = true;
        } else {
            nextQuestion();
        }
    }
}
