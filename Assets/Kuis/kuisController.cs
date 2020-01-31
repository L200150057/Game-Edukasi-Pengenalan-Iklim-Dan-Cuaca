using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kuisController : MonoBehaviour
{
    public TextAsset pertanyaan;
    public static string[] Question;
    public static string[][] Answer;
    public static int jumlahSoal = 10;
    public static int jumlahSkor;
    public static float targetTime;
    public static List<int> noSoal = new List<int>();
    // Start is called before the first frame update
    void Awake()
    {
        Question = pertanyaan.text.Split('\n');
        Answer = new string[Question.Length][];
        int lineNum = 0;
        foreach (string line in Question)
        {
            Answer[lineNum++] = line.Split(',');
        }
    }

    public static void buatList()
    {
        noSoal.Clear();
        for (int i = 0; i < jumlahSoal; i++)
        {
            noSoal.Add(i);
        }
        
        targetTime = 100.0f;

        jumlahSkor = 0;
    }
}
