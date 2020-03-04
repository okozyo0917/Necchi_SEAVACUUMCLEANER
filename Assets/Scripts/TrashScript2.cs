using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScript2 : MonoBehaviour
{
    public int point = 3;
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
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<PlayerScript>().AddScore(point);
            Destroy(this.gameObject);


        }

    }
}
