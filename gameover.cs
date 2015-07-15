using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameover : MonoBehaviour
{
	int score = 0;        
	Text scoretext;  
	
	void Start()
	{
		scoretext = GetComponent <Text> ();
		score = PlayerPrefs.GetInt("Score");
		//Se extrage scor-ul salvat in playerprefs si se afiseaza pe ecran in scena de game-over.
	}
	void Update() {
	    scoretext.text ="SCORE: " + (int)score;}                   
}  


