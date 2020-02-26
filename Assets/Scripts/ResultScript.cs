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

  
    public int score_num = 0; // スコア変数


    // Start is called before the first frame update
    void Start()
    {
        // スコアのロード
        score_num = PlayerPrefs.GetInt("SCORE", 0);
        score_num += HIREScript.total;
    }

    // Update is called once per frame
    void Update()
    {




      

        // スコアを保存
        PlayerPrefs.SetInt("SCORE", score_num);
        PlayerPrefs.Save();

        Scorelabel2.text = HIREScript.total.ToString();
        Scorelabel3.text = score_num.ToString();

        if (Input.GetKey(KeyCode.Space))
        {

            SceneManager.LoadScene("Title");


        }
    }
}
