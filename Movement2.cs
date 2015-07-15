using UnityEngine;
using System.Collections;

public class Movement2 : MonoBehaviour {
	void Update() {

		float movespeed = 30f;
		transform.position += Vector3.left * movespeed * Time.deltaTime;
	}
}