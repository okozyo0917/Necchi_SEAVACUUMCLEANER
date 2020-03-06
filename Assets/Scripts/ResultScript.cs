using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultScript : MonoBehaviour
{
    public Text Scorelabel2;
    public Text Scorelabel3;
    public Text Scorelabel4;

  
    public static float  score_num = 0; // スコア変数
    float a;


    // Start is called before the first frame update
    void Start()
    {
        // スコアのロード
        score_num = PlayerPrefs.GetFloat("SCORE", 0);
        score_num += HIREScript.total;
    }

    // Update is called once per frame
    void Update()
    {




      

        // スコアを保存
        PlayerPrefs.SetFloat("SCORE", score_num);
        PlayerPrefs.Save();

        Scorelabel2.text = HIREScript.total.ToString();
        Scorelabel3.text = score_num.ToString();
        a = score_num/1.66f;
        Scorelabel4.text =a.ToString(); 

        if (Input.GetKeyDown(KeyCode.Space))
        {

            SceneManager.LoadScene("Title");
            HIREScript.total = 0;
            Debug.Log("title");

        }

        if (a >=100)
        {
            SceneManager.LoadScene("GAMECLEAR");
        }


    }
}
