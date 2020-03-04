using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCreater2 : MonoBehaviour
{
    public GameObject petbottle;
    float timer = 0;
    int interval = 5;
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
            Instantiate(petbottle, new Vector3(Random.Range(-400f, 400f), -2, Random.Range(-300f, 200)), transform.rotation);
            timer = 0;

        }

    }
}
