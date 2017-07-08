using UnityEngine;
using System.Collections;

public class CheckExit : MonoBehaviour {

	public GameObject player;
	public int exitnum;

	void Update () 
	{
		if (player.GetComponent<Movement> ().counter == exitnum) 
		{
			Destroy (gameObject);
		}
	}
}
