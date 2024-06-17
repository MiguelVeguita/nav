using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class patrullador : MonoBehaviour
{
    public Transform[] puntos;
    private int current = 0;
    private NavMeshAgent patrunav;
    public Transform npc;
    public static event Action onmovenpc;
    public float radio=5f;
    // Start is called before the first frame update
    void Start()
    {
        patrunav=GetComponent<NavMeshAgent>();
        mover();
        
    }
    void mover()
    {

        if (puntos.Length == 0) 
        {
            return;
        }
        patrunav.destination=puntos[current].position;
        current=(current+1)%puntos.Length;
    }
    // Update is called once per frame
    void Update()
    {
        if (!patrunav.pathPending && patrunav.remainingDistance < 0.5f)
        {
            mover(); 
        }
        float distancia=Vector3.Distance(transform.position,npc.position);


        if (distancia < radio) 
        {
            onmovenpc?.Invoke();
        }

    }
}
