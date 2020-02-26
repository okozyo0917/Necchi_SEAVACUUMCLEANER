using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript2 : MonoBehaviour
{
    public Text timerText1;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        TimerScript.timer1 -= Time.deltaTime;
        TimerScript.timer = TimerScript.timerMax + TimerScript.timer1;
        timerText1.text = Mathf.FloorToInt(TimerScript.timer).ToString();


        if (TimerScript.timer <= 0)
        {
            SceneManager.LoadScene("RESULT");
        }
    }
}
