using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[System.Serializable]
public class TileType
{

    public string type; 
    public int movementCost; 
    public Tile tileTexture; 
    public bool passable; 


}
