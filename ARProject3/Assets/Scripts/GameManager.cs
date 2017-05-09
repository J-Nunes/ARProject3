using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    public static GameManager g_manager;
    public Transform Respawn_1;
    public Transform Respawn_2;
    public int max_soldiers_capacity = 10;
    public int min_soliders_Capacity = 5;

    List<GameObject> soldiers = new List<GameObject>();
    public GameObject[] people;

    //Attack Positions
    public Transform attack_pos1_respawn1;
    public Transform attack_po2_respawn1;
    public Transform attack_pos1_respawn2;
    public Transform attack_po2_respawn2;


    void Awake()
    {
        g_manager = this;
    }

    // Use this for initialization
    void Start ()
    {
        

    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

   
}
