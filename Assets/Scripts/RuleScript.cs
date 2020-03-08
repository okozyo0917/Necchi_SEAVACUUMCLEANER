using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RuleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            if(SceneManager.GetActiveScene().name == "Rule1") {
                SceneManager.LoadScene("Rule2");
            }
            if (SceneManager.GetActiveScene().name == "Rule2")
            {
                SceneManager.LoadScene("Rule3");
            }
            if (SceneManager.GetActiveScene().name == "Rule3")
            {
                SceneManager.LoadScene("Rule4");
            }
            if (SceneManager.GetActiveScene().name == "Rule4")
            {
                SceneManager.LoadScene("Rule5");
            }
            if (SceneManager.GetActiveScene().name == "Rule5")
            {
                SceneManager.LoadScene("Rule6");
            }
            if (SceneManager.GetActiveScene().name == "Rule6")
            {
                SceneManager.LoadScene("Title");
            }



        }

        if (Input.GetKeyDown("left"))
        {
       
            if (SceneManager.GetActiveScene().name == "Rule2")
            {
                SceneManager.LoadScene("Rule1");
            }
            if (SceneManager.GetActiveScene().name == "Rule3")
            {
                SceneManager.LoadScene("Rule2");
            }
            if (SceneManager.GetActiveScene().name == "Rule4")
            {
                SceneManager.LoadScene("Rule3");
            }
            if (SceneManager.GetActiveScene().name == "Rule5")
            {
                SceneManager.LoadScene("Rule4");
            }
            if (SceneManager.GetActiveScene().name == "Rule6")
            {
                SceneManager.LoadScene("Rule5");
            }



        }
    }
}
