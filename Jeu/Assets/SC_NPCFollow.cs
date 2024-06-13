using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SC_NPCFollow : MonoBehaviour
{
    public Transform transformToFollow;
    NavMeshAgent agent;

    void Start()
    {
          agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = transformToFollow.position;
    }
}
