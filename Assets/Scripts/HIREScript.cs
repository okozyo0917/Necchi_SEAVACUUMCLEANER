using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HIREScript : MonoBehaviour
{

  
    public static int total;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter(Collision col)
    {
        total += ScoreScript.Count;

            ScoreScript.Count = 0;
        
    }
}
