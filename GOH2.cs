using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GOH2 : MonoBehaviour
{
	int score2 = 0;        
	Text scoretext2;
	int highscore2 = 0;
	Text highscoretext2;
	
	void Start()
	{
		scoretext2 = GetComponent <Text> ();
		highscoretext2 = GetComponent <Text> (); 
		score2 = PlayerPrefs.GetInt("Score2");
		highscore2 = PlayerPrefs.GetInt ("Highscore2");
		//Se extrage scor-ul salvat in playerprefs si se afiseaza pe ecran in scena de game-over.
	}
	void Update() {
		
		
		highscoretext2.text = "HIGHSCORE (Hard) : " + (int)highscore2;
	}
}  
