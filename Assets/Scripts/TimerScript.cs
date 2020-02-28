using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public static float timerMax = 40f;
    public static float timer = 0f;
    public static float timer1 = 0f;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        timer1 -= Time.deltaTime;
        timer = timerMax + timer1;
        timerText.text = Mathf.FloorToInt(timer).ToString();


        if (timer < 0)
        {
            timer1 = 0;
            timer = 0;
            SceneManager.LoadScene("RESULT");
           
        }


    }
}
