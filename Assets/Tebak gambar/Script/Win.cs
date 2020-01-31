using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public static bool menang;    
    public GameObject wrong;
    public GameObject correct;
    private bool jalankan_sekali;
    public List<Transform> huruf = new List<Transform>() {};
    // Start is called before the first frame update
    void Start()
    {
        jalankan_sekali = false;
        menang = false;
        foreach (Transform child in transform)
        {
            huruf.Add(child);
        }
    }
    // Update is called once per frame
    void Update()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Level_1":
                if (
                    huruf[0].childCount > 0 &&
                    huruf[1].childCount > 0 &&
                    huruf[2].childCount > 0 &&
                    huruf[3].childCount > 0 &&
                    huruf[4].childCount > 0 &&
                    jalankan_sekali == false
                )
                {
                    string jawaban = "";
                    foreach (Transform child in transform)
                    {
                        jawaban += child.GetChild(0).name.Substring(6, 1);
                    }
                    if (jawaban == "CERAH"){
                        Scene_management.unlockNextlevel();
                        StartCoroutine(Benar());
                        wrong.SetActive(false);
                        jalankan_sekali = true;
                    }else{
                        StartCoroutine(salah());
                        reset();
                    }
                }
                break;

            case "Level_2":
                if (
                    huruf[0].childCount > 0 &&
                    huruf[1].childCount > 0 &&
                    huruf[2].childCount > 0 &&
                    huruf[3].childCount > 0 &&
                    huruf[4].childCount > 0 &&
                    jalankan_sekali == false
                )
                {
                    string jawaban = "";
                    foreach (Transform child in transform)
                    {
                        jawaban += child.GetChild(0).name.Substring(6, 1);
                    }
                    if (jawaban == "HUJAN"){
                        Scene_management.unlockNextlevel();
                        StartCoroutine(Benar());
                        wrong.SetActive(false);
                        jalankan_sekali = true;
                    }else{
                        StartCoroutine(salah());
                        reset();
                    }
                }
                break;

            case "Level_3":
                if (
                    huruf[0].childCount > 0 &&
                    huruf[1].childCount > 0 &&
                    huruf[2].childCount > 0 &&
                    huruf[3].childCount > 0 &&
                    huruf[4].childCount > 0 &&
                    huruf[5].childCount > 0 &&
                    jalankan_sekali == false
                )
                {
                    string jawaban = "";
                    foreach (Transform child in transform)
                    {
                        jawaban += child.GetChild(0).name.Substring(6, 1);
                    }
                    if (jawaban == "BANJIR"){
                        Scene_management.unlockNextlevel();
                        StartCoroutine(Benar());
                        wrong.SetActive(false);
                        jalankan_sekali = true;
                    }else{
                        StartCoroutine(salah());
                        reset();
                    }
                }
                break;

            case "Level_4":
                if (
                    huruf[0].childCount > 0 &&
                    huruf[1].childCount > 0 &&
                    huruf[2].childCount > 0 &&
                    huruf[3].childCount > 0 &&
                    huruf[4].childCount > 0 &&
                    huruf[5].childCount > 0 &&
                    huruf[6].childCount > 0 &&
                    jalankan_sekali == false
                )
                {
                    string jawaban = "";
                    foreach (Transform child in transform)
                    {
                        jawaban += child.GetChild(0).name.Substring(6, 1);
                    }
                    if (jawaban == "BERAWAN"){
                        Scene_management.unlockNextlevel();
                        StartCoroutine(Benar());
                        wrong.SetActive(false);
                        jalankan_sekali = true;
                    }else{
                        StartCoroutine(salah());
                        reset();
                    }
                }
                break;

                case "Level_5":
                if (
                    huruf[0].childCount > 0 &&
                    huruf[1].childCount > 0 &&
                    huruf[2].childCount > 0 &&
                    huruf[3].childCount > 0 &&
                    huruf[4].childCount > 0 &&
                    huruf[5].childCount > 0 &&
                    huruf[6].childCount > 0 &&
                    jalankan_sekali == false
                )
                {
                    string jawaban = "";
                    foreach (Transform child in transform)
                    {
                        jawaban += child.GetChild(0).name.Substring(6, 1);
                    }
                    if (jawaban == "MENDUNG"){
                        Scene_management.unlockNextlevel();
                        StartCoroutine(Benar());
                        wrong.SetActive(false);
                        jalankan_sekali = true;
                    }else{
                        StartCoroutine(salah());
                        reset();
                    }
                }
                break;

                case "Level_6":
                if (
                    huruf[0].childCount > 0 &&
                    huruf[1].childCount > 0 &&
                    huruf[2].childCount > 0 &&
                    huruf[3].childCount > 0 &&
                    huruf[4].childCount > 0 &&
                    huruf[5].childCount > 0 &&
                    huruf[6].childCount > 0 &&
                    jalankan_sekali == false
                )
                {
                    string jawaban = "";
                    foreach (Transform child in transform)
                    {
                        jawaban += child.GetChild(0).name.Substring(6, 1);
                    }
                    if (jawaban == "NELAYAN"){
                        Scene_management.unlockNextlevel();
                        StartCoroutine(Benar());
                        wrong.SetActive(false);
                        jalankan_sekali = true;
                    }else{
                        StartCoroutine(salah());
                        reset();
                    }
                }
                break;

                case "Level_7":
                if (
                    huruf[0].childCount > 0 &&
                    huruf[1].childCount > 0 &&
                    huruf[2].childCount > 0 &&
                    huruf[3].childCount > 0 &&
                    huruf[4].childCount > 0 &&
                    huruf[5].childCount > 0 &&
                    huruf[6].childCount > 0 &&
                    huruf[7].childCount > 0 &&
                    huruf[8].childCount > 0 &&
                    jalankan_sekali == false
                )
                {
                    string jawaban = "";
                    foreach (Transform child in transform)
                    {
                        jawaban += child.GetChild(0).name.Substring(6, 1);
                    }
                    if (jawaban == "SEPAKBOLA"){
                        Scene_management.unlockNextlevel();
                        StartCoroutine(Benar());
                        wrong.SetActive(false);
                        jalankan_sekali = true;
                    }else{
                        StartCoroutine(salah());
                        reset();
                    }
                }
                break;

                case "Level_8":
                if (
                    huruf[0].childCount > 0 &&
                    huruf[1].childCount > 0 &&
                    huruf[2].childCount > 0 &&
                    huruf[3].childCount > 0 &&
                    huruf[4].childCount > 0 &&
                    huruf[5].childCount > 0 &&
                    huruf[6].childCount > 0 &&
                    huruf[7].childCount > 0 &&
                    huruf[8].childCount > 0 &&
                    huruf[9].childCount > 0 &&
                    jalankan_sekali == false
                )
                {
                    string jawaban = "";
                    foreach (Transform child in transform)
                    {
                        jawaban += child.GetChild(0).name.Substring(6, 1);
                    }
                    if (jawaban == "KEKERINGAN"){
                        StartCoroutine(Benar());
                        wrong.SetActive(false);
                        jalankan_sekali = true;
                    }else{
                        StartCoroutine(salah());
                        reset();
                    }
                }
                break;
        }
    }

    IEnumerator Benar(){
        GameObject.Find("Winsound").GetComponent<AudioSource>().Play();
        correct.SetActive(true);
        yield return new WaitForSeconds(1);
        menang = true;
    }

    IEnumerator salah(){
        GameObject.Find("Wrongsound").GetComponent<AudioSource>().Play();
        wrong.SetActive(true);
        yield return new WaitForSeconds(1);
        wrong.SetActive(false);
    }

    void reset(){
        for (int i = 0; i < transform.childCount; i++)
        {
            if(transform.GetChild(i).childCount != 0){
                Destroy(transform.GetChild(i).GetChild(0).gameObject);
            }
        }
        for (int i = 0; i < GameObject.Find("Huruf").transform.childCount; i++){
            if(GameObject.Find("Huruf").transform.GetChild(i).childCount != 0){
                Destroy(GameObject.Find("Huruf").transform.GetChild(i).GetChild(0).gameObject);
            }
        }
        GameObject.Find("Huruf").GetComponent<Generate>().enabled = false;
        GameObject.Find("Huruf").GetComponent<Generate>().enabled = true;
    }
    
}
