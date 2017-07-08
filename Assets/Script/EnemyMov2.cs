using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMov2 : MonoBehaviour 
{
	public Vector3 LastPosition;
	public GameObject player;
	public bool onlyonce = true;
	public string Stage;
	int pcount;
	int paths;

	void Start () 
	{
		paths = Random.Range (1, 4);

		if (paths == 1) {
			transform.position = new Vector3 (14, 1.25f, 0);
		}

		if (paths == 2) {
			transform.position = new Vector3 (4, -0.75f, 0);
		}

		if (paths == 3) {
			transform.position = new Vector3 (8, 5.25f, 0);
		}

		if (paths == 4) {
			transform.position = new Vector3 (-8, 7.25f, 0);
		}
	}

	void Update ()
	{
		pcount = player.GetComponent<Movement> ().counter;

		if (paths == 1) 
		{
			Path1 ();
		}

		if (paths ==2) 
		{
			Path2 ();
		}

		if (paths == 3) 
		{
			Path3 ();
		}

		if (paths == 4) 
		{
			Path4 ();
		}
	}

	void Path1()
	{
		if (pcount == 1) 
		{
			Left ();
		}
		if (pcount == 2) 
		{
			Left ();
		}
		if (pcount == 3) 
		{
			Down ();
		}
		if (pcount == 4) 
		{
			Down ();
		}
		if (pcount == 5) 
		{
			Down ();
		}
		if (pcount == 6) 
		{
			Left ();
		}
		if (pcount == 7) 
		{
			Left ();
		}
		if (pcount == 8) 
		{
			Left ();
		}
		if (pcount == 9) 
		{
			Left ();
		}
		if (pcount == 10) 
		{
			Up ();
		}
		if (pcount == 11) 
		{
			Up ();
		}
		if (pcount == 12) 
		{
			Left ();
		}
		if (pcount == 13) 
		{
			Up ();
		}
		if (pcount == 14) 
		{
			Up ();
		}
		if (pcount == 15) 
		{
			Up ();
		}
		if (pcount == 16) 
		{
			Left ();
		}
		if (pcount == 17)
		{
			Left ();
		}
		if (pcount == 18)
		{
			Left ();
		}
		if (pcount == 19) 
		{
			Left ();
		}
		if (pcount == 20)
		{
			Down ();
		}
		if (pcount == 21)
		{
			Down ();
		}
		if (pcount == 22)
		{
			Down ();
		}
		if (pcount == 23) 
		{
			Down ();
		}
		if (pcount == 24) 
		{
			Right ();
		}
		if (pcount == 25) 
		{
			Right ();
		}
		if (pcount == 26) 
		{
			Right ();
		}
		if (pcount == 27) 
		{
			Down ();
		}
		if (pcount == 28) 
		{
			Down ();
		}
		if (pcount == 29) 
		{
			Left ();
		}
		if (pcount == 30) 
		{
			Left ();
		}
		if (pcount == 31) 
		{
			Left ();
		}
		if (pcount == 32) 
		{
			Left ();
		}
		if (pcount == 33) 
		{
			Left ();
		}
	}

	void Path2()
	{
		if (pcount == 1) 
		{
			Up ();
		}
		if (pcount == 2) 
		{
			Up ();
		}
		if (pcount == 3) 
		{
			Right ();
		}
		if (pcount == 4) 
		{
			Right ();
		}
		if (pcount == 5) 
		{
			Right ();
		}
		if (pcount == 6) 
		{
			Right ();
		}
		if (pcount == 7) 
		{
			Down ();
		}
		if (pcount == 8) 
		{
			Down ();
		}
		if (pcount == 9) 
		{
			Down ();
		}
		if (pcount == 10) 
		{
			Left ();
		}
		if (pcount == 11) 
		{
			Down ();
		}
		if (pcount == 12) 
		{
			Left ();
		}
		if (pcount == 13) 
		{
			Left ();
		}
		if (pcount == 14) 
		{
			Left ();
		}
		if (pcount == 15) 
		{
			Up ();
		}
		if (pcount == 16) 
		{
			Left ();
		}
		if (pcount == 17) 
		{
			Up ();
		}
		if (pcount == 18) 
		{
			Left ();
		}
		if (pcount == 19) 
		{
			Up ();
		}
		if (pcount == 20) 
		{
			Up ();
		}
		if (pcount == 21) 
		{
			Left ();
		}
		if (pcount == 22) 
		{
			Left ();
		}
		if (pcount == 23) 
		{
			Down ();
		}
		if (pcount == 24) 
		{
			Left ();
		}
		if (pcount == 25) 
		{
			Left ();
		}
		if (pcount == 26) 
		{
			Left ();
		}
		if (pcount == 27) 
		{
			Left ();
		}
		if (pcount == 28) 
		{
			Down ();
		}
		if (pcount == 29) 
		{
			Down ();
		}
		if (pcount == 30) 
		{
			Down ();
		}
		if (pcount == 31) 
		{
			Left ();
		}
	}

	void Path3()
	{
		if (pcount == 1) 
		{
			Down ();
		}
		if (pcount == 2) 
		{
			Down ();
		}
		if (pcount == 3) 
		{
			Left ();
		}
		if (pcount == 4) 
		{
			Left ();
		}
		if (pcount == 5) 
		{
			Down ();
		}
		if (pcount == 6) 
		{
			Left ();
		}
		if (pcount == 7) 
		{
			Left ();
		}
		if (pcount == 8) 
		{
			Up ();
		}
		if (pcount == 9) 
		{
			Left ();
		}
		if (pcount == 10) 
		{
			Up ();
		}
		if (pcount == 11) 
		{
			Up ();
		}
		if (pcount == 12) 
		{
			Left ();
		}
		if (pcount == 13) 
		{
			Left ();
		}
		if (pcount == 14) 
		{
			Left ();
		}
		if (pcount == 15) 
		{
			Down ();
		}
		if (pcount == 16) 
		{
			Right ();
		}
		if (pcount == 17) 
		{
			Down ();
		}
		if (pcount == 18) 
		{
			Down ();
		}
		if (pcount == 19) 
		{
			Down ();
		}
		if (pcount == 20) 
		{
			Right ();
		}
		if (pcount == 21) 
		{
			Right ();
		}
		if (pcount == 22) 
		{
			Down ();
		}
		if (pcount == 23) 
		{
			Down ();
		}
		if (pcount == 24) 
		{
			Left ();
		}
		if (pcount == 25) 
		{
			Left ();
		}
		if (pcount == 26) 
		{
			Left ();
		}
		if (pcount == 27) 
		{
			Up ();
		}
		if (pcount == 28) 
		{
			Up ();
		}
		if (pcount == 29) 
		{
			Left ();
		}
		if (pcount == 30) 
		{
			Left ();
		}
		if (pcount == 31) 
		{
			Left ();
		}
	}
		
	void Path4()
	{
		if (pcount == 1) 
		{
			Right ();
		}
		if (pcount == 2) 
		{
			Right ();
		}
		if (pcount == 3) 
		{
			Right ();
		}
		if (pcount == 4) 
		{
			Up ();
		}
		if (pcount == 5) 
		{
			Up ();
		}
		if (pcount == 6) 
		{
			Right ();
		}
		if (pcount == 7) 
		{
			Right ();
		}
		if (pcount == 8) 
		{
			Up ();
		}
		if (pcount == 9) 
		{
			Up ();
		}
		if (pcount == 10) 
		{
			Right ();
		}
		if (pcount == 11) 
		{
			Right ();
		}
		if (pcount == 12) 
		{
			Down ();
		}
		if (pcount == 13) 
		{
			Down ();
		}
		if (pcount == 14) 
		{
			Right ();
		}
		if (pcount == 15) 
		{
			Right ();
		}
		if (pcount == 16) 
		{
			Right ();
		}
		if (pcount == 17) 
		{
			Right ();
		}
	}

	void Left()
	{	
		if (onlyonce) 
		{
			transform.position = transform.position - new Vector3 (2, 0, 0);
			onlyonce = false;
		}
	}

	void Right()
	{
		if (onlyonce) 
		{
			transform.position = transform.position + new Vector3 (2, 0, 0);
			onlyonce = false;
		}
	}

	void Up()
	{
		if (onlyonce) 
		{
			transform.position = transform.position + new Vector3 (0, 2, 0);
			onlyonce = false;
		}
	}

	void Down()
	{
		if (onlyonce) 
		{
			transform.position = transform.position - new Vector3 (0, 2, 0);
			onlyonce = false;
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			SceneManager.LoadScene(Stage); 
		}
	}
}
