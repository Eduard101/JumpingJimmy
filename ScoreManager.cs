using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	public static float score;        // Scorul player-ului.
	
	
	Text text;                      // Referinta la componenta text care afiseaza scorul.
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		score = 0;
	}
	
	
	void Update ()
	{
		score += Time.deltaTime * 100;
		//Scorul creste odata cu trecerea timpului prin Time.deltaTime.
		text.text = "SCORE: " + (int)(score);
	}

	void OnDisable()
	{
		PlayerPrefs.SetInt ("Score", (int)score);
		//Se salveaza scorul in playerprefs pentru a fii afisate in scena de game over.
		                    }
}