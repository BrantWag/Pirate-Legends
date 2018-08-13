using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;//to call GM

	void OnTriggerEnter2D()
	{
		gameManager.CompleteLevel ();// shows level complete canvas and restarts via GM
	}


}
