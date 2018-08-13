using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour 
{
    //variables 
    public GameObject bulletPrefab;
	public Transform shootPoint;
    public Transform shootPoint2;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			Instantiate (bulletPrefab, shootPoint.position, shootPoint.rotation); //if key is pressed then calls bullet prefab
		}
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(bulletPrefab, shootPoint2.position, shootPoint2.rotation);//if key is pressed then calls bullet prefab
        }
    }
}
