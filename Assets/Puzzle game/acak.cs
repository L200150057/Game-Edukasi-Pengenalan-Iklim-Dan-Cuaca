using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class acak : MonoBehaviour
{
    private List<float> miring = new List<float>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).eulerAngles = new Vector3(0f, 0f, makeUniqueRandom());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float makeUniqueRandom()
    {
        if (miring.Count == 0){
            miring = new List<float>{0f, 90f, 180f, 270f};
        }
        var index = miring[Random.Range(0, miring.Count)];
        miring.Remove(index);
        return index;       
    }
}
