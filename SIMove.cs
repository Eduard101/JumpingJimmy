using UnityEngine;
using System.Collections;

public class SIMove : MonoBehaviour {
	void Update() {
		
		float movespeed = 60f;
		transform.position += Vector3.left * movespeed * Time.deltaTime;
	}
}