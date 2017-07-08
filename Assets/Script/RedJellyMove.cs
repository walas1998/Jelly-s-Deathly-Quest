using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class RedJellyMove : MonoBehaviour {

	public string Stage;
	public float speed;
	public int direction = 1;

	void Update()
	{
		transform.Translate (Vector3.right * speed * direction * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Target") 
		{
			if (direction == 1) 
			{
				direction = -1;
			} 

			else 
			{

				direction = 1;
			}
		}

		if (other.gameObject.tag == "Player")
		{
			SceneManager.LoadScene(Stage); 
		}
	}
}