using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameover2 : MonoBehaviour
{
	int score = 0;        
	Text scoretext;
	int highscore = 0;
	Text highscoretext;
	
	void Start()
	{
		scoretext = GetComponent <Text> ();
		highscoretext = GetComponent <Text> (); 
		score = PlayerPrefs.GetInt("Score");
		highscore = PlayerPrefs.GetInt ("Highscore");
		//Se extrage scor-ul salvat in playerprefs si se afiseaza pe ecran in scena de game-over.
	}
	void Update() {

		
		highscoretext.text = "HIGHSCORE: " + (int)highscore;
	}
}  

