using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript2 : MonoBehaviour
{
    public Text Scorelabel2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Scorelabel2.text = HIREScript.total.ToString();
    }


}
