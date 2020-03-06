using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;
    bool moveForwardFlg;
    bool moveBackFlg;

    float moveSpeed = 60;
    float rotateSpeed = 100;

    public AudioClip sound;
    public AudioClip sound2;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveForwardFlg = Input.GetKey(KeyCode.UpArrow);
        moveBackFlg = Input.GetKey(KeyCode.DownArrow);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.right * -rotateSpeed * Time.deltaTime);
        }


    }

    void FixedUpdate()
    {
        if (moveForwardFlg)
        {
            rb.velocity = transform.forward * moveSpeed;
        }
        else if (moveBackFlg)
        {
            rb.velocity = -transform.forward * moveSpeed;
        }
        else
        {
            rb.velocity = Vector3.zero;

        }

    }


    public void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Door")
        {

            SceneManager.LoadScene("Entrance2");
        }

        if (col.collider.tag == "Door2")
        {

            SceneManager.LoadScene("Main");


        }

 

    }


    public void AddScore(int value)
    {
        ScoreScript.Count += value;
        Debug.Log(ScoreScript.Count);
        audioSource.PlayOneShot(sound);
    }

    public void GameOver()
    {
        TimerScript.timer1 = 0;
        TimerScript.timer = 0;
        ScoreScript.Count = 0;
        SceneManager.LoadScene("GameOver");
    }


    public void AddTime(int value1)
    {
        TimerScript.timer1 += value1;
        Debug.Log("TimerUp");
        audioSource.PlayOneShot(sound2);
    }


}
