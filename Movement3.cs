using UnityEngine;
using System.Collections;

public class Movement3: MonoBehaviour {
	
	void Update() {
		
		float movespeed = 40f;
		transform.position += Vector3.right * movespeed * Time.deltaTime;

	}
}
