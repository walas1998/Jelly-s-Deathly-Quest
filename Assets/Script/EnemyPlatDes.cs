using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlatDes : MonoBehaviour {

	public GameObject bottom;

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.tag == "Enemy") 
		{
			Instantiate (bottom, transform.position, Quaternion.identity);
		}
	}
}
