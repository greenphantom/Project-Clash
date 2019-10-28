using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;



[System.Serializable]
public class TileBlock 
{

    public string type; 
    public int movementCost; 
    public Tile tileTexture; 
    public bool passable;
	public int advBonus;

	TileBlock () {
		type = this.type;
		movementCost = this.movementCost;
		tileTexture = this.tileTexture;
		passable = this.passable; 
		advBonus = this.advBonus; 
	}
	
	void Start() {
		
	}
}


  

