using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HIREScript : MonoBehaviour
{

  
    public static int total=0;
    public GameObject DoorOpen;

    public AudioClip sound3;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter(Collision col)
    {
        total += ScoreScript.Count;
        if (ScoreScript.Count >= 1)
        {
            audioSource.PlayOneShot(sound3);
        }
        ScoreScript.Count = 0;
        DoorOpen.SetActive(true);

    }
}
