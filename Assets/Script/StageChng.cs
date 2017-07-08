using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StageChng : MonoBehaviour {

	public string Stage;

	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			StartCoroutine("WaitToChange");

			other.GetComponent<Movement> ().enabled = false;
			other.GetComponent<Animator> ().SetBool ("Win", true);
		}
	}

	IEnumerator WaitToChange()
	{
		yield return new WaitForSeconds (1.8f);

		SceneManager.LoadScene(Stage);
	}
}
