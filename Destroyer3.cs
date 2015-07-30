using UnityEngine;
using System.Collections;

public class Destroyer3 : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			Application.LoadLevel(4);
			return;
			// Daca destroyer-ul atinge player-ul , se va trece la urmatoarea scena.
		}
		
		if(other.gameObject.transform.parent)
		{
			Destroy (other.gameObject.transform.parent.gameObject);
		}
		else
		{
			Destroy (other.gameObject);
		}
	}
}
