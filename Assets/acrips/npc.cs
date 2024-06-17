using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;


public class npc : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent nc;

    void OnEnable()
    {
        patrullador.onmovenpc += MoveToTarget;
    }

    void OnDisable()
    {
        patrullador.onmovenpc -= MoveToTarget;
    }
    void Start()
    {
        nc = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        
    }
    public void MoveToTarget()
    {
        if (target != null)
        {
            nc.destination = target.position;
        }
    }
}
