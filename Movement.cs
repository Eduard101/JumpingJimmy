using UnityEngine;
using System.Collections;

public class Movement: MonoBehaviour {

	void Update() {
		
		float movespeed = 30f;
		transform.position += Vector3.right * movespeed * Time.deltaTime;
		//Se creaza o variabila ce retine viteza platformei si se foloseste functia transform.position pentru a misca
		//platforma folosind Vector3
	}
}