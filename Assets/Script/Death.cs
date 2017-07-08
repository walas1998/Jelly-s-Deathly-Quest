using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Death : MonoBehaviour {

	public string stage;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Bottom")
		{
			gameObject.GetComponent<Movement> ().enabled = false;
			gameObject.GetComponent<Animator> ().SetBool ("Death", true);
			StartCoroutine ("WaitToDie");
		}
	}

	IEnumerator WaitToDie()
	{
		yield return new WaitForSeconds (1);
		SceneManager.LoadScene(stage);
	}
}
