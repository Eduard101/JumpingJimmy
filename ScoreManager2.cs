using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager2 : MonoBehaviour
{
	public static float score2;        // Scorul player-ului.
	
	
	Text text;                      // Referinta la componenta text care afiseaza scorul.
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		score2 = 0;
	}
	
	
	void Update ()
	{
		score2 += Time.deltaTime * 100;
		//Scorul creste odata cu trecerea timpului prin Time.deltaTime.
		text.text = "SCORE: " + (int)(score2);
	}

	public void IncreaseScore(int amount)
	{
		score2 += amount;
	}
	
	void OnDisable()
	{
		PlayerPrefs.SetInt ("Score2", (int)score2);
		//Se salveaza scorul in playerprefs pentru a fii afisate in scena de game over.
		int newHighscore2;
		newHighscore2 = (int)score2;
		int oldHighscore2 = PlayerPrefs.GetInt("Highscore2");
		if(newHighscore2 > oldHighscore2)
			PlayerPrefs.SetInt("Highscore2", newHighscore2);
	}
	
	
}