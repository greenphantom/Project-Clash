using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System;
public class KeyMovement2 : MonoBehaviour
{
	public Tilemap tilemap; 
	void Awake() {
		
	}
	
    
	 void Update () {
		
		float range =  1;
		GameObject player = GameObject.Find("Player");
		
		Debug.Log(tilemap.GetSprite(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5),0)));
		//Debug.Log(player.transform.position.x);
		//Debug.Log(player.transform.position.y);
		Debug.Log((int)player.transform.position.x);
		Debug.Log((int)player.transform.position.y);
		if(tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5),0)).name == "mountain") {
			Debug.Log("Rocky");
		}
												//Check the tilemap for tile data 
        if (Input.GetKeyDown(KeyCode.DownArrow) && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5-range),0)).name != "mountain" && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5-range),0)).name != "water")
        {
		transform.position = new Vector2(transform.position.x, transform.position.y-range);
		}
		 if (Input.GetKeyUp(KeyCode.UpArrow) && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5+range),0)).name != "mountain" && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5+range),0)).name != "water")
        {
		transform.position = new Vector2(transform.position.x, transform.position.y+range);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow) && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5+range),(int)(player.transform.position.y-.5),0)).name != "mountain" && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5+range),(int)(player.transform.position.y-.5),0)).name != "water")
        {
		transform.position = new Vector2(transform.position.x+range, transform.position.y);
		}
		 if (Input.GetKeyUp(KeyCode.LeftArrow) && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5-range),(int)(player.transform.position.y-.5),0)).name != "mountain" && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5-range),(int)(player.transform.position.y-.5),0)).name != "water")
        {
		transform.position = new Vector2(transform.position.x-range, transform.position.y);
		}

	}
}