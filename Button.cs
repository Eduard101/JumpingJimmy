using UnityEngine;
using System.Collections;
using UnityEngine.UI; // required when using UI elements in scripts

public class Button : MonoBehaviour {
	
	public bool interactable;
	public UnityEngine.UI.Button startButton;
	public static float score;
	
	
	void Update () 
	{
		score = PlayerPrefs.GetInt ("Highscore");// checks if the players are ready and if the start button is useable
		
		if (score >= 4000 && startButton.interactable == false) 
		{
			//allows the start button to be used
			startButton.interactable = true;

		}
	}
}