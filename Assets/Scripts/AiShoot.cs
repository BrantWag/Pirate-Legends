using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiShoot : MonoBehaviour

{
    public Transform target;
    public Transform firePoint;

    //varaibles
    public float FireRate = 1f;
    private float fireCountdown = 0f;

    public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (fireCountdown <= 0f) //tells object when to fire 
        {
            Shoot();
            fireCountdown = 1f / FireRate;
        }

        fireCountdown -= Time.deltaTime;
	}

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);//calls prefab
    }
}
