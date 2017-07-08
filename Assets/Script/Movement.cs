using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Vector3 LastPosition;
	public int counter = 0;
	public GameObject Enemy;
	private GameGrid grid;

	void Start ()
	{
		grid = GetComponent<GameGrid> ();
	}

	void Update () 
	{
		
		/// Izquierda
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			if (grid.CheckRoom (4)) {
				//lo mueves
				//actualizas el playerPos
				transform.position = transform.position - new Vector3 (2, 0, 0);
				transform.rotation = Quaternion.Euler (0, 180, 0);
				grid.playerPos = new Vector2 (grid.playerPos.x, grid.playerPos.y - 1);
				LastPosition = transform.position + new Vector3 (2, 0, 0);
				counter = counter + 1;
				Enemy.GetComponent<EnemyMov2> ().onlyonce = true;
			} else {
				Debug.Log ("NOPE");
			}
		} 

		/// Derecha
		if (Input.GetKeyDown (KeyCode.D)) 
		{
			if (grid.CheckRoom (2)) {
				//lo mueves
				//actualizas el playerPos
				transform.position = transform.position + new Vector3 (2, 0, 0);
				transform.rotation = Quaternion.Euler (0,0,0);
				grid.playerPos = new Vector2 (grid.playerPos.x, grid.playerPos.y + 1);
				LastPosition = transform.position - new Vector3 (2, 0, 0);
				counter = counter + 1;
				Enemy.GetComponent<EnemyMov2> ().onlyonce = true;
			}else{
				Debug.Log ("NOPE");
			}
		} 

		/// Adelante
		if (Input.GetKeyDown (KeyCode.W)) 
		{
			if (grid.CheckRoom (1)) {
				//lo mueves
				//actualizas el playerPos
				transform.position = transform.position + new Vector3 (0, 2, 0);
				grid.playerPos = new Vector2 (grid.playerPos.x - 1, grid.playerPos.y);
				LastPosition = transform.position - new Vector3 (0, 2, 0);
				counter = counter + 1;
				Enemy.GetComponent<EnemyMov2> ().onlyonce = true;
			}else{
				Debug.Log ("NOPE");
			}
		} 

		/// Atras
		if (Input.GetKeyDown (KeyCode.S)) 
		{
			if (grid.CheckRoom (3)) {
				//lo mueves
				//actualizas el playerPos
				transform.position = transform.position - new Vector3 (0, 2, 0);
				grid.playerPos = new Vector2 (grid.playerPos.x + 1, grid.playerPos.y);
				LastPosition = transform.position + new Vector3 (0, 2, 0);
				counter = counter + 1;
				Enemy.GetComponent<EnemyMov2> ().onlyonce = true;
			}else{
				Debug.Log ("NOPE");
			}
		} 
	}
}

