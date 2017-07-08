using UnityEngine;
using System.Collections;

public class CheckExit2 : MonoBehaviour {

	public GameObject puppy;

	void Update () 
	{
		if (puppy.GetComponent<CheckMellow> ().saved == true) 
		{
			Destroy (gameObject);
		}
	}
}
