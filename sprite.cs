using UnityEngine;
using System.Collections;

public class sprite : MonoBehaviour {

	public Sprite Monster_Dead; // Drag your first sprite here
	public Sprite Monster_Jump; // Drag your second sprite here
	
	private SpriteRenderer spriteRenderer; 
	
	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
			spriteRenderer.sprite = Monster_Dead; // set the sprite to sprite1
	}
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space)) // If the space bar is pushed down
		{
			ChangeTheDamnSprite (); // call method to change sprite
		}
	}
	
	void ChangeTheDamnSprite ()
	{
		if (spriteRenderer.sprite == Monster_Dead ) // if the spriteRenderer sprite = sprite1 then change to sprite2
		{
			spriteRenderer.sprite = Monster_Jump;
		}
		else
		{
			spriteRenderer.sprite = Monster_Dead; // otherwise change it back to sprite1
		}
	}

}