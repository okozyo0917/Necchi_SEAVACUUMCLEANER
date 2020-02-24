using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCreater : MonoBehaviour
{
    public GameObject petbottle;
    float timer = 0;
    int interval = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            Instantiate(petbottle, new Vector3(Random.Range(-600f, 600f),-2, Random.Range(-600f, 200f)), transform.rotation);
            timer = 0;
 
        }
    }
}
