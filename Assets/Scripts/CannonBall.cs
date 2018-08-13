using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    //variables
    public Transform tf;
    public float speed;
    public float time;

    // Use this for initialization
    void Start()
    {
        tf = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Destroy(this.gameObject, time);//destroys object after a set amount of time
    }

    //Tells bullet to move 
    public void Move()
    {
        tf.position += tf.up * speed * 0.05f;//moves ball 
    }
}
