using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    public LevelManager levelmanager;


    // Use this for initialization
    void Start ()
    {
        levelmanager = FindObjectOfType<LevelManager>();//finds level manager when game starts 

    }
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.tag == "CannonBall") && (this.gameObject.tag == "Player"))
        {
            levelmanager.RespawnPlayer();//respawns player 
        }
    }
}
