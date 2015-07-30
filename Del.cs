using UnityEngine;
using System.Collections;

public class Del : MonoBehaviour {
	
	public void DeletePlayerPrefs () {
		PlayerPrefs.DeleteAll();
	}
}