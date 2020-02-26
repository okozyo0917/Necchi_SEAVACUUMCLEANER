using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScript : MonoBehaviour
{
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
        if (col.collider.tag == "Player")
        {
            SendMessage("AddScore");
            Destroy(this.gameObject);


        }
    }

    void AddScore()
    {
        ScoreScript.Count += 1;
        Debug.Log(ScoreScript.Count);
    }
}
