using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    [SerializeField]
    public GameObject[] prefab;
    private List<int> tempat = new List<int>();
    // Start is called before the first frame update
    void OnEnable()
    {
        for (int i = 0; i < GameObject.Find("Huruf").transform.childCount; i++)
        {
            tempat.Add(i);
        }
        
        for (int i = 0; i < GameObject.Find("Huruf").transform.childCount; i++)
        {
            GameObject Huruf = Instantiate(prefab[i], new Vector3(0, 0), Quaternion.identity);
            Huruf.transform.SetParent(GameObject.Find("Huruf").transform.GetChild(makeUniqueRandom()));
            Huruf.transform.localScale = Huruf.transform.parent.localScale / 2;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int makeUniqueRandom()
    {
        var index = tempat[Random.Range(0, tempat.Count)];
        tempat.Remove(index);
        return index;       
    }
}
