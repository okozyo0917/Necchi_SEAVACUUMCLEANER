using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FishScript2 : MonoBehaviour
{
    GameObject[] points = new GameObject[7];
    int targetIndex = 0;
    public float speed = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        targetIndex = Random.Range(0, 6);
        points = GameObject.FindGameObjectsWithTag("Points");
        transform.position = points[targetIndex].transform.position;
        transform.LookAt(points[targetIndex].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, points[targetIndex].transform.position) < 5f){
            targetIndex = Random.Range(0, 6);
            transform.LookAt(points[targetIndex].transform.position);
        }
    }

    public void OnCollisionEnter(Collision col)
    {
        col.gameObject.GetComponent<PlayerScript>().GameOver();
    }
}
