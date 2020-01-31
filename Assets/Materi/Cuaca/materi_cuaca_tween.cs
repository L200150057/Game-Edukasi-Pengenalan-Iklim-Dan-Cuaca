using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materi_cuaca_tween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        tween1();
        tween2();
        tween3();
        tween4();
        tween5();
        tween6();
        tween7();
    }

    // Update is called once per frame
    void Update()
    {
        // RotateSample loop
        GameObject.Find("Gambar4").transform.Rotate(0, 0, 20*Time.deltaTime);
    }

    void tween1(){
        iTween.ScaleTo(GameObject.Find("Gambar1"), iTween.Hash("x", 0.9, "y", 0.9, "time", 1, "easeType", "linear", "loopType", "pingPong", "islocal", true));
    }

    void tween2(){
        iTween.ScaleTo(GameObject.Find("Gambar2"), iTween.Hash("x", 0.9, "y", 0.9, "time", 1, "easeType", "linear", "loopType", "pingPong", "islocal", true));
    }

    void tween3(){
        iTween.ScaleTo(GameObject.Find("Gambar3"), iTween.Hash("x", 0.9, "y", 0.9, "time", 1, "easeType", "linear", "loopType", "pingPong", "islocal", true));
    }
    void tween4(){
        iTween.ScaleTo(GameObject.Find("Gambar4"), iTween.Hash("x", 0.9, "y", 0.9, "time", 1, "easeType", "linear", "loopType", "pingPong", "islocal", true));
    }

    void tween5(){
        iTween.MoveTo(GameObject.Find("berawan1"), iTween.Hash("x", 50, "y", -20, "time", 2, "easeType", "linear", "loopType", "pingPong", "islocal", true));
        iTween.MoveTo(GameObject.Find("berawan2"), iTween.Hash("x", -50, "y", -70, "time", 2, "easeType", "linear", "loopType", "pingPong", "islocal", true));
        iTween.ScaleTo(GameObject.Find("matahari"), iTween.Hash("x", 0.8, "y", 0.8, "time", 2, "easeType", "linear", "loopType", "pingPong", "islocal", true));
    }

    void tween6(){
        iTween.MoveTo(GameObject.Find("mendung1"), iTween.Hash("x", -25, "y", 25, "time", 2, "easeType", "linear", "loopType", "pingPong", "islocal", true));
        iTween.MoveTo(GameObject.Find("mendung2"), iTween.Hash("x", 50, "y", -50, "time", 2, "easeType", "linear", "loopType", "pingPong", "islocal", true));
    }

    void tween7(){
        iTween.MoveTo(GameObject.Find("cuaca_hujan_awan"), iTween.Hash("x", 25, "y", 60, "time", 2, "easeType", "linear", "loopType", "pingPong", "islocal", true));
        iTween.MoveTo(GameObject.Find("cuaca_hujan_awan2"), iTween.Hash("x", -25, "y", 10, "time", 2, "easeType", "linear", "loopType", "pingPong", "islocal", true));
        iTween.MoveTo(GameObject.Find("cuaca_hujan_air"), iTween.Hash("x", 0, "y", -130, "time", 1, "easeType", "linear", "loopType", "loop", "islocal", true));
    }
}
