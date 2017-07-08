using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Debug.Log ("CONGRATS! YOU DID IT!");
		}
	}
}
