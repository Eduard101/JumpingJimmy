using UnityEngine;
using System.Collections;

public class Movement4 : MonoBehaviour {
	void Update() {
		
		float movespeed = 40f;
		transform.position += Vector3.left * movespeed * Time.deltaTime;
	}
}
