using UnityEngine;
using System.Collections;

public class DestroyPlat : MonoBehaviour {

	public GameObject player;
	public GameObject bottom;

	void Update () 
	{
		if (transform.position == player.GetComponent<Movement> ().LastPosition) 
		{
			Destroy (gameObject);
			Instantiate (bottom, transform.position, Quaternion.identity);
		}
	}
}
