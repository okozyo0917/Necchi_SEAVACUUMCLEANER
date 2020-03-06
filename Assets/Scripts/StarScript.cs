using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    public int point2= 3;


    // Start is called before the first frame update
    void Start()
    {
   
        this.gameObject.transform.position = new Vector3(Random.Range(-16f, 44f), -3, Random.Range(-260f, -332f));
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<PlayerScript>().AddTime(point2);
          
            Destroy(this.gameObject);


        }
    }
}
