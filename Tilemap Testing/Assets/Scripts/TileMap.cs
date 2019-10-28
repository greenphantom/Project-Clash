using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour
{

    public TileBlock[] tileTypes; 
    int[,] tiles; 

    int mapSizeX = 22;
    int mapSizeY = 10; 

    // Start is called before the first frame update
    void Start()
    {
        tiles = new int[mapSizeX, mapSizeY]; 
        for(int i = 0; i < mapSizeX; ++i) {
            for(int j = 0; j < mapSizeY; ++j) {
                tiles[i,j] = 0;
            }
        }
        
    }
}
