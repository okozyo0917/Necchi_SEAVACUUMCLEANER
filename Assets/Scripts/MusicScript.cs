﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {

        DontDestroyOnLoad(gameObject);




    }

    // Update is called once per frame
    void Update()
    {

        if (SceneManager.GetActiveScene().name == "Title")
        {
            Destroy(gameObject);
        }


    }
}
