using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {

	AudioSource source1;
	AudioSource source2;
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
			source1.Play();
		
		if (Input.GetKeyDown(KeyCode.DownArrow))
			source2.Play();
	}

}