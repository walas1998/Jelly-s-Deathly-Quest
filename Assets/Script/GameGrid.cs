using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour {

	public bool [,] grid;
	public int ancho = 17;
	public int alto = 10;
	public string RECORDATORIO = "X ES FILA , Y ES COLUMNA";
	public List <Vector2> availableSpaces;
	public Vector2 playerPos;

	void Start () 
	{
		grid = new bool[alto,ancho];
		for (int i = 0; i < alto; i++)
		{
			for (int j = 0; j < ancho; j++) 
			{
				grid [i, j] = true;
			}
		}


		foreach (Vector2 v in availableSpaces)
		{
			grid [(int)v.x, (int)v.y] = false;
		}
	}
	
	public bool CheckRoom(int dir)
	{


		 //AGREGMOS ESTA LINEA POR GIT
		bool room = true;

		switch (dir) 
		{
		case 1:
			if (grid [(int)playerPos.x - 1, (int)playerPos.y] == true) {
				room = true;
			}
			else
			{
				room = false;
			}

			break;
		case 2:
			if (grid [(int)playerPos.x, (int)playerPos.y + 1] == true) {
				room = true;
			} 
			else 
			{
				room = false;
			}
			break;
		case 3:
			if (grid [(int)playerPos.x + 1, (int)playerPos.y] == true) {
				room = true;
			}
			else
			{
				room = false;
			}
			break;
		case 4: if (grid [(int)playerPos.x, (int)playerPos.y - 1] == true){
				room = true;
			}
			else
			{
				room = false;
			}
			break;

		}

		return room;
	}

}
