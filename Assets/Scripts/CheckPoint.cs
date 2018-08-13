using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    public LevelManager levelmanager; // calls levelmanager script

    // Use this for initialization
    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>(); //find levelmanager at start of game 

    }
    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelmanager.currentCheckpoint = gameObject; //sets last checkpoin to current spawn
        }
    }
}
