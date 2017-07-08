using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crack : MonoBehaviour 
{
	Animator anim;

	void Start () 
	{
		anim = GetComponent<Animator>();
	}

	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.gameObject.tag == "Player") 
		{
			anim.SetBool ("Destroy", true);
			GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1);

		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			anim.SetBool ("Destroy", false);
		}
	}
}
