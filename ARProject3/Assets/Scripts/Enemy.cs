using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
   
    Transform position_enemy;
    public Transform position_attack;
    public NavMeshAgent agent;
    Vector3 destination;

    GameManager g_manager;
    public float radius;

    void Awake()
    {
        position_enemy = GetComponent<Transform>();
    }

    // Use this for initialization
    void Start ()
    {
        //Choose Respawn at the beginning
        Choose_Respawn();
       
        //After the respawn of the character, this goes to the attack position
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
       

        destination = position_attack.position;
        destination.x += random.x;
        destination.z += random.y;

        agent.SetDestination(destination);
    }

    void Choose_Respawn()
    {
        //Choose Respawn
        g_manager = GameObject.Find("Game_Manager").GetComponent<GameManager>();

        int value_respawn = Random.Range(1, 10);
     

        if (value_respawn <= 5)
        {
            position_enemy.position = g_manager.Respawn_2.position;
        }
        else
        {
            position_enemy.position = g_manager.Respawn_1.position;
        }

        
    }

  
}
