using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMellow : MonoBehaviour {

	public bool saved = false;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			GetComponent<SpriteRenderer> ().enabled = false;

			saved = true;
		}
	}
}
