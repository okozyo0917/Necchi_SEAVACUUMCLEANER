using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;
    bool moveForwardFlg;
    bool moveBackFlg;

    float moveSpeed = 50;
    float rotateSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
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


}
