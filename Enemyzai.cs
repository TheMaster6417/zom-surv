using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemyzai : MonoBehaviour
{
	NavMeshAgent nm;
	public Transform playertarget;


    // Start is called before the first frame update
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        nm.SetDestination(playertarget.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
