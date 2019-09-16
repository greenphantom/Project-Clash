using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System;
public class KeyMovement2 : MonoBehaviour
{
	public Tilemap tilemap;
	float range =  1;
	int horizontalMovement = 0;
	int verticalMovement = 0;
	float offset = .5f;
	void Awake() {
		
	}
	
    
	 void Update () {
		GameObject player = GameObject.Find("Player");
		horizontalMovement = 0;
		verticalMovement = 0;
		Vector3Int myVector = new Vector3Int(0,0,0);

		Debug.Log(tilemap.GetSprite(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5),0)));
		Debug.Log("Player X: " + (int)(player.transform.position.x-offset));
		Debug.Log("Player Y: " + (int)(player.transform.position.y-offset));
		if(tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5),0)).name == "mountain") {
			Debug.Log("Rocky");
		}

		//Check the tilemap for tile data 
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
			verticalMovement = -1;
			myVector = new Vector3Int((int)(player.transform.position.x-offset),(int)(player.transform.position.y-offset-range),0);
		}
		else if (Input.GetKeyUp(KeyCode.UpArrow)) {
			verticalMovement = 1;
			myVector = new Vector3Int((int)(player.transform.position.x-offset),(int)(player.transform.position.y-offset+range),0);
		}
		else if (Input.GetKeyUp(KeyCode.RightArrow)) {
			horizontalMovement = 1;
			myVector = new Vector3Int((int)(player.transform.position.x-offset+range),(int)(player.transform.position.y-offset),0);
		}
		else if (Input.GetKeyUp(KeyCode.LeftArrow)) {
			horizontalMovement = -1;
			myVector = new Vector3Int((int)(player.transform.position.x-offset-range),(int)(player.transform.position.y-offset),0);
		}

		// If the player wants to move
		if (horizontalMovement != 0 || verticalMovement != 0) {
			// Check if it's a valid tile
			
			Debug.Log("Vector: "+myVector);
			TileBase targetTile = tilemap.GetTile(myVector); //.name != "mountain" && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5-range));
			if (tilemap.GetTile(myVector).name != "mountain" && tilemap.GetTile(myVector).name != "water") {
				Move(horizontalMovement,verticalMovement);
			}
		 }
	}

	private void Move(int x, int y) {
        transform.position =  transform.position + new Vector3(x, y, 0);
	}
}