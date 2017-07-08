using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Wall")
		{
			transform.position = GetComponent<Movement> ().LastPosition;
		}
	}
}
