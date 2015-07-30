using UnityEngine;
using System.Collections;

public class powerup : MonoBehaviour {

	ScoreManager hud;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{ hud = GameObject.Find ("Text").GetComponent<ScoreManager>();
		  hud.IncreaseScore(200);
		  Destroy (this.gameObject);

	
	}
	
	
}
}
