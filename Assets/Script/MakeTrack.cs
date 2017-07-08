using UnityEngine;
using System.Collections;

public class MakeTrack : MonoBehaviour {

	public GameObject player;
	public GameObject bottom;
	bool isbroken = false;

	void Update () 
	{
		if (transform.position == player.GetComponent<Movement> ().LastPosition) 
		{
			if (!isbroken) 
			{
				Instantiate (bottom, transform.position, Quaternion.identity);
			}

			isbroken = true;
		}
	}
}
