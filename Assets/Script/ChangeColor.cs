using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	public GameObject icon;

	void Update () 
	{
		if (icon.transform.position.y == transform.position.y) {
			GetComponent<SpriteRenderer> ().color = new Color (0.28f, 0, 0.42f, 0.95f);
		}
		else 
		{
			GetComponent<SpriteRenderer> ().color = new Color (0.58f, 0, 0.6f, 0.75f);
		}
	}
}
