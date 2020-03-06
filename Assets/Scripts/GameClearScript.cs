using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearScript : MonoBehaviour
{

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ResultScript.score_num = 0;
        timer += Time.deltaTime;
        if (timer > 20)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
