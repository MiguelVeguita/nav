using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class player : MonoBehaviour
{
    private NavMeshAgent pla;
    public GameObject objetivo;
    // Start is called before the first frame update
    void Start()
    {
        pla = GetComponent<NavMeshAgent>();
        pla.destination = objetivo.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                pla.destination=hit.point;
            }
        }



    }
}
