using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckExit3 : MonoBehaviour {

	public GameObject enemy;

	void Update () 
	{
		if (enemy.GetComponent<EnemyDeath> ().checkexit == true) 
		{
			Destroy (gameObject);
		}
	}
}
