using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pertanyaan : MonoBehaviour
{
    void Start(){
        if (kuisController.noSoal.Count != 0){

            int nomor = kuisController.noSoal[Random.Range(0, kuisController.noSoal.Count)];
            transform.GetComponent<TMPro.TMP_Text>().text = kuisController.Answer[nomor][0];
            kuisController.noSoal.Remove(nomor);

            int i = 1;
            foreach (Transform t in transform.GetComponentInChildren<Transform>())
            {
                t.transform.GetComponentInChildren<Text>().text = kuisController.Answer[nomor][i++];
            }

            foreach (Transform t in transform.GetComponentInChildren<Transform>())
            {
                t.transform.SetSiblingIndex(Random.Range(0, 3));
            }

        }
    }
}
