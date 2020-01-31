using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Puzzle_control : MonoBehaviour
{
    public static bool Solved;
    public List<Transform> Pictures = new List<Transform>() {};
    private GameObject centang;
    private GameObject nama_gambar;
    private GameObject suara_menang;
    private GameObject Image;
    private bool jalankan_sekali;
    
    void Start()
    {
        Solved = false;
        jalankan_sekali = false;
        centang = GameObject.Find("checked-symbol");
        nama_gambar = GameObject.Find("Nama gambar");
        suara_menang = GameObject.Find("Winsound");
        Image = GameObject.Find("Image-inner");
        
        foreach (Transform child in GameObject.Find("Image-inner").transform)
        {
            Pictures.Add(child);
        }
    }

    void Update()
    {   
        switch (SceneManager.GetActiveScene().name){
            
            case "Level_1":
            case "Level_4":
            case "Level_7":
            case "Level_10":
                if (
                    Pictures[0].eulerAngles.z < 1 &&
                    Pictures[1].eulerAngles.z < 1 &&
                    Pictures[2].eulerAngles.z < 1 &&
                    Pictures[3].eulerAngles.z < 1 &&
                    jalankan_sekali == false
                )
                {
                    berhasil();
                }
                break;

            case "Level_2":
            case "Level_5":
            case "Level_8":
            case "Level_11":
                if (
                    Pictures[0].eulerAngles.z < 1 &&
                    Pictures[1].eulerAngles.z < 1 &&
                    Pictures[2].eulerAngles.z < 1 &&
                    Pictures[3].eulerAngles.z < 1 &&
                    Pictures[4].eulerAngles.z < 1 &&
                    Pictures[5].eulerAngles.z < 1 &&
                    Pictures[6].eulerAngles.z < 1 &&
                    Pictures[7].eulerAngles.z < 1 &&
                    Pictures[8].eulerAngles.z < 1 &&
                    jalankan_sekali == false
                )
                {
                    berhasil();
                }
                break;

            case "Level_3":
            case "Level_6":
            case "Level_9":
            case "Level_12":
                if (
                    Pictures[0].eulerAngles.z < 1 &&
                    Pictures[1].eulerAngles.z < 1 &&
                    Pictures[2].eulerAngles.z < 1 &&
                    Pictures[3].eulerAngles.z < 1 &&
                    Pictures[4].eulerAngles.z < 1 &&
                    Pictures[5].eulerAngles.z < 1 &&
                    Pictures[6].eulerAngles.z < 1 &&
                    Pictures[7].eulerAngles.z < 1 &&
                    Pictures[8].eulerAngles.z < 1 &&
                    Pictures[9].eulerAngles.z < 1 &&
                    Pictures[10].eulerAngles.z < 1 &&
                    Pictures[11].eulerAngles.z < 1 &&
                    Pictures[12].eulerAngles.z < 1 &&
                    Pictures[13].eulerAngles.z < 1 &&
                    Pictures[14].eulerAngles.z < 1 &&
                    Pictures[15].eulerAngles.z < 1 &&
                    jalankan_sekali == false
                )
                {
                    berhasil();
                }
                break;
        }
    }

    public void berhasil(){
        Solved = true;
        jalankan_sekali = true;
        centang.transform.localScale = new Vector2(1, 1);
        nama_gambar.transform.localScale = new Vector2(1, 1);
        suara_menang.GetComponent<AudioSource>().Play();
        Image.GetComponent<GridLayoutGroup>().spacing = new Vector2(0, 0);
        Scene_management.unlockNextlevel_Puzzle();
    }
}
