using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class FishScript : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();    
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player") {
            col.gameObject.GetComponent<PlayerScript>().GameOver();
        }

    }
}
