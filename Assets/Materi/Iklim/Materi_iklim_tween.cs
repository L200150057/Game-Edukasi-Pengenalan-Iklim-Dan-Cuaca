using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materi_iklim_tween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        tween1();
        tween2();
        tween3();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void tween1(){
        iTween.MoveTo(GameObject.Find("awan1"), iTween.Hash("x", -75, "y", 120, "time", 2.5, "easeType", "linear", "loopType", "pingPong", "islocal", true));
        iTween.MoveTo(GameObject.Find("awan2"), iTween.Hash("x", 75, "y", -75, "time", 2.5, "easeType", "linear", "loopType", "pingPong", "islocal", true));
    }

    void tween2(){
        iTween.ScaleTo(GameObject.Find("matahari"), iTween.Hash("x", 1.5, "y", 1.5, "time", 1.5, "easeType", "linear", "loopType", "pingPong", "islocal", true));
    }

    void tween3(){
        iTween.MoveTo(GameObject.Find("salju1"), iTween.Hash("x", -25, "y", -120, "time", 2.5, "easeType", "linear", "loopType", "loop", "islocal", true));
        iTween.MoveTo(GameObject.Find("salju2"), iTween.Hash("x", 80, "y", -25, "time", 2.5, "easeType", "linear", "loopType", "loop", "islocal", true));
    }

}
