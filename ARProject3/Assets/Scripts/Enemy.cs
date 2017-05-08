using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform attack_pos;
    public NavMeshAgent agent;
    public float radius;

	// Use this for initialization
	void Start ()
    {
        CalcRandomPos();
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void CalcRandomPos()
    {
        Vector2 random = Random.insideUnitCircle * radius;
        Debug.Log(random);
        Vector3 destination;

        destination = attack_pos.position;
        destination.x += random.x;
        destination.z += random.y;

        agent.SetDestination(destination);
    }
}
