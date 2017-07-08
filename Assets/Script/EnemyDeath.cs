using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour {

	public bool checkexit = false;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Bottom")
		{
			GetComponent<SpriteRenderer> ().enabled = false;
			GetComponent<EnemyMov2> ().enabled = false;
			checkexit = true;
		}
	}
}
