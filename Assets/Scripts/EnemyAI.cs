using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
    //variables 
    public float speed;
    public Transform target;
    public float chaseRange;

	void Update ()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target.position); //finds distance to target from its postion 
        if (distanceToTarget < chaseRange)
        {
            Vector3 targetDir = target.position - transform.position; //figure out were target is in relation to this gameobject
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;//rotates sprite to face target 
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);
            transform.Translate(Vector3.up * Time.deltaTime * speed);//move toward player
        }
	}
}
