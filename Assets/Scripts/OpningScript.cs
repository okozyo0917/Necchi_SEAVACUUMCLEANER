using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpningScript : MonoBehaviour
{
    private float timer = 0f;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 10.5f)
        {
            SceneManager.LoadScene("Entrance");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            SceneManager.LoadScene("Entrance");


        }

    }
}
