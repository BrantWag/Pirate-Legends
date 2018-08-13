using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    //varaibles 
    public LevelManager levelmanager; //to call levelmanger
    public AudioClip Sound;//sound
    public AudioClip Enemy;//sound
    public AudioClip Restart;//sound
    private AudioSource audioSource;//sound

    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>(); //finds level manager at start of game 
    }

    void Update()
    {
        audioSource = GetComponent<AudioSource>(); // gets audiosource 
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.tag == "CannonBall")) 
        {
            audioSource.PlayOneShot(Sound);//play sound 
            Destroy(other.gameObject); //destoys other object it collides with 
            Destroy(this.gameObject, 2.5f);//waits to destoy this object
        }
        if ((other.gameObject.tag == "CannonBall") && (this.gameObject.tag == "Player"))
        {
            audioSource.PlayOneShot(Restart);//plays sound
            levelmanager.RespawnPlayer(); //respawns player 
        }
        if ((other.gameObject.tag == "CannonBall") && (this.gameObject.tag == "Enemy"))
        {
            audioSource.PlayOneShot(Enemy);//plays sound
            Destroy(this.gameObject, 5f);//waits to destoy this object
        }
        if ((other.gameObject.tag == "Player") && (this.gameObject.tag == "Enemy"))
        {
            levelmanager.RespawnPlayer(); //respawns player 
        }
    }
}
