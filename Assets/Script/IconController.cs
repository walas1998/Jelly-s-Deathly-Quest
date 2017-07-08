using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IconController : MonoBehaviour {

	public int x;

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.S))
		{
			if (transform.position.y == -1f) {
				transform.position = new Vector2 (x, -3.8f);
			}

			else if (transform.position.y == -3.8f) {
				transform.position = new Vector2 (x, -7f);
			}

			else if (transform.position.y == -7f) {
				transform.position = new Vector2 (x, -1f);
			}
		}

		if (Input.GetKeyDown (KeyCode.W))
		{
			if (transform.position.y == -3.8f) {
				transform.position = new Vector2 (x, -1f);
			}

			else if (transform.position.y == -7f) {
				transform.position = new Vector2 (x, -3.8f);
			}

			else if (transform.position.y == -7f) {
				transform.position = new Vector2 (x, -1f);
			}

			else if (transform.position.y == -1f) {
				transform.position = new Vector2 (x, -7f);
			}
		}

		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			if (transform.position.y == -1f) 
			{
				SceneManager.LoadScene("Stage 1 - Garden");
			}

			if (transform.position.y == -3.8f) 
			{
				SceneManager.LoadScene("Credits");
			}

			if (transform.position.y == -3.8f) 
			{
				Application.Quit ();
			}
		}
	}
}
