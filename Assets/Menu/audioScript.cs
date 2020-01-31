﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour
{
    private static audioScript instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null){
            Destroy(gameObject);
        }else{
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}
