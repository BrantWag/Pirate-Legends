using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckpoint; //sets current checkpoint in game 

    private ControllerPlayer player; //calls player script 

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<ControllerPlayer>();//finds player script 
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RespawnPlayer()
    {
        Debug.Log("Player Respwan"); // shows me that it works 
        player.transform.position = currentCheckpoint.transform.position; //respawns players at last checkpoint the went through.
    }
}
