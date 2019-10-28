using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System;
public class KeyMovement2 : MonoBehaviour
{
	public Tilemap tilemap;
<<<<<<< HEAD
	public TileBlock[] blocks; 
	int movement = 5; 
=======
	float range =  1;
	int horizontalMovement = 0;
	int verticalMovement = 0;
	float offset = .5f;
	int delay = 10;
	int count = -1;

	UnitState state = UnitState.Standby;

	Vector3Int myVector = new Vector3Int(0,0,0);

	GameObject player;
	
	void Start() {
		player = GameObject.Find("Player");
	} 

>>>>>>> ed085af99188929f4b8a8176ed4b4147f02b47b5
	void Awake() {
		
	}

	private void refreshPlayer(){
		player = GameObject.Find("Player");
	}
	
    
	 void Update () {
<<<<<<< HEAD
		
		float range =  1;
		 
		GameObject player = GameObject.Find("Player");
		Debug.Log(tilemap.GetSprite(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5),0)));
		for(int i = 0; i < blocks.Length; i++) {
		if(tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5),0)) == blocks[i].tileTexture){
		Debug.Log("We have found a match");
		Debug.Log("The adv bonus of this terrain is " + blocks[i].advBonus);
		}
		}
		//Debug.Log(player.transform.position.x);
		//Debug.Log(player.transform.position.y);
		Debug.Log((int)player.transform.position.x);
		Debug.Log((int)player.transform.position.y);
		if(tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5),0)).name == "mountain") {
			Debug.Log("Rocky");
		}
												//Check the tilemap for tile data 
        if (Input.GetKeyDown(KeyCode.DownArrow) && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5-range),0)).name != "mountain" && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5-range),0)).name != "water" && movement != 0)
        {
		transform.position = new Vector2(transform.position.x, transform.position.y-range);
		movement = getBlock(movement);
		}
		 if (Input.GetKeyUp(KeyCode.UpArrow) && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5+range),0)).name != "mountain" && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5+range),0)).name != "water" && movement != 0)
        {
		transform.position = new Vector2(transform.position.x, transform.position.y+range);
		movement = getBlock(movement);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow) && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5+range),(int)(player.transform.position.y-.5),0)).name != "mountain" && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5+range),(int)(player.transform.position.y-.5),0)).name != "water" && movement != 0)
        {
		transform.position = new Vector2(transform.position.x+range, transform.position.y);
		movement = getBlock(movement);
		}
		 if (Input.GetKeyUp(KeyCode.LeftArrow) && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5-range),(int)(player.transform.position.y-.5),0)).name != "mountain" && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5-range),(int)(player.transform.position.y-.5),0)).name != "water" && movement != 0)
        {
		transform.position = new Vector2(transform.position.x-range, transform.position.y);
		movement = getBlock(movement);
		}
		Debug.Log("The movement available is " + movement);
	}
	
	int getBlock(int movement) {
	GameObject player = GameObject.Find("Player");
	//Check what tile we are on and update the movement of the character according to the spaces that it has moved. 
	for(int i = 0; i < blocks.Length; i++) {
		if(tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5),0)) == blocks[i].tileTexture){
		Debug.Log("We have found a match");
		Debug.Log("The adv bonus of this terrain is " + blocks[i].advBonus);
		movement = movement - blocks[i].movementCost;
		}
		}
	Debug.Log("The new movement is " + movement);
	return movement; 
}
=======
		// Bind count so it never overflows
		count = ++count % delay;

		// Refresh player reference
		refreshPlayer();

		// Reset Horizontal and Vertical modifiers
		horizontalMovement = 0;
		verticalMovement = 0;

		Debug.Log("Converted Player Coordinates with Offset: " + convertV3toV3Int(player.transform.position));

		//Check the tilemap for tile data 
		if (state == UnitState.Moving) {
			// Don't reset the myVector
			Debug.Log("My vector is still: "+myVector);
		}
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			verticalMovement = -1;
			myVector = convertV3toV3Int(new Vector3(player.transform.position.x,player.transform.position.y-range,0));
		}
		else if (Input.GetKeyUp(KeyCode.UpArrow)) {
			verticalMovement = 1;
			myVector = convertV3toV3Int(new Vector3(player.transform.position.x,player.transform.position.y+range,0));
		}
		else if (Input.GetKeyUp(KeyCode.RightArrow)) {
			horizontalMovement = 1;
			myVector = convertV3toV3Int(new Vector3(player.transform.position.x+range,player.transform.position.y,0));
		}
		else if (Input.GetKeyUp(KeyCode.LeftArrow)) {
			horizontalMovement = -1;
			myVector = convertV3toV3Int(new Vector3(player.transform.position.x-range,player.transform.position.y,0));
		}
		else if (Input.GetKeyDown(KeyCode.Mouse0)) {
			Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			myVector = convertV3toV3Int(target);
			state = UnitState.Moving;
			Debug.Log("MOVING");
		}

		// If the player wants to move
			if (horizontalMovement != 0 || verticalMovement != 0 || state == UnitState.Moving) {
			// Check if it's a valid tile
			TileBase targetTile = tilemap.GetTile(myVector); //.name != "mountain" && tilemap.GetTile(new Vector3Int((int)(player.transform.position.x-.5),(int)(player.transform.position.y-.5-range));
			if (isValidTiletoMove(targetTile)) {
				Debug.Log("VALID");
				// If the target is greater than one distance away we need to do A* on it
				// Delay the movement loop
				if (state == UnitState.Moving) {
					Debug.Log("Mouse Movement");
					if (count % delay == 0) {
						moveToAStarTarget();
					}
				}
				// Otherwise, we can simply move to it
				else {
					Move(horizontalMovement,verticalMovement);
					Debug.Log("Key Movement");
				}		
			}
			// If the tile is not valid, the state needs to be reset to standby
			else if (state != UnitState.Standby) {
				state = UnitState.Standby;
			}
		 }
	}

	private void moveToAStarTarget() {
		Debug.Log("A*");
		// Generate a list of potential points
		List<Vector3Int> potentialTargets = generateAStarTargets();
		
		// Calculate the one that leads to the shortest distance
		double shortestDistance = Double.MaxValue;
		Vector3Int ret = new Vector3Int(100,100,0);
		foreach (Vector3Int v in potentialTargets) {
			double temp = getDistance(v+convertV3toV3Int(player.transform.position),myVector);
			// if the new vector is closer to the destination
			if (temp < shortestDistance) {
				shortestDistance = temp;
				ret = v;
			}
		}
		Debug.Log("The movement vector chosen is: "+ret);

		// Finally, we move to that position
		Move(ret);

		Debug.Log("The ending position was: "+ player.transform.position);

		// If target is reached, reset state
		if (getDistance(myVector,getPlayerIntVector()) <= 1f) {
			Debug.Log("STANDBY");
			state = UnitState.Standby;
		}//*/
	}

	private double getDistance(Vector3Int potentialTarget, Vector3Int target) {
		return Vector3Int.Distance(potentialTarget, target);
	}

	private List<Vector3Int> generateAStarTargets() {
		Vector3Int start = convertV3toV3Int(new Vector3(player.transform.position.x, transform.position.y,0));
		//Debug.Log("My Start = "+start);
		List<Vector3Int> potentialTargets = new List<Vector3Int>();
		potentialTargets.Add(convertV3toV3Int(new Vector3(0,range,0)));
		potentialTargets.Add(convertV3toV3Int(new Vector3(0,-range,0)));
		potentialTargets.Add(convertV3toV3Int(new Vector3(range,0,0)));
		potentialTargets.Add(convertV3toV3Int(new Vector3(-range,0,0)));

		// Filter to only the valid points
		return potentialTargets.FindAll(vector => isValidTiletoMove(vector+convertV3toV3Int(player.transform.position)));
	}

	private bool isValidTiletoMove(TileBase tileBase) {
		if (tileBase == null) {
			state = UnitState.Standby;
			Debug.Log("STANDBY");
			return false;
		}
		else return tileBase.name != "mountain" && tileBase.name != "water";
	}

	private bool isValidTiletoMove(Vector3Int vector3Int) {
		TileBase tileBase = tilemap.GetTile(vector3Int);
		if (tileBase == null) {
			state = UnitState.Standby;
			return false;
		}
		else return tileBase.name != "mountain" && tileBase.name != "water";
	}

	private void Move(int x, int y) {
        player.transform.position =  player.transform.position + new Vector3(x, y, 0);
	}

	private void Move(Vector3Int v, bool withOffset = false) {
		player.transform.position = v + player.transform.position;
		if (withOffset) { offsetPlayer(); }
	}

	private Vector3Int getPlayerIntVector() {
		return convertV3toV3Int(player.transform.position);
	}

	private Vector3Int convertV3toV3Int(Vector3 v3) {
		return new Vector3Int(Convert.ToInt32(v3.x),Convert.ToInt32(v3.y),0);
	}

	private Vector3Int convertV3toV3Int(float x, float y) {
		return new Vector3Int(Convert.ToInt32(x),Convert.ToInt32(y),0);
	}

	private void offsetPlayer(float off=.5f){
		Debug.Log("Pre Offset Coordinates: "+player.transform.position);
		// There is an issue with the way we have our coordinates. In this current iteration, two rows and columns are considered x = 0, y = 0 respectively. 
		// This messed with the pathing, casuing it to skip over the row/column.
		float x = player.transform.position.x;
		float y = player.transform.position.y;
		// For reference 
		/*
		Coordinate(0.5.-0.5,0) -> (0,-1,0) ** currently
		 */
		//x = x 
		player.transform.position = new Vector3(x+off,y+off,0);
		Debug.Log("Offset Coordinates: "+player.transform.position);
	}

>>>>>>> ed085af99188929f4b8a8176ed4b4147f02b47b5
}