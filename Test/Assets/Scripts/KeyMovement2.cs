using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System;
public class KeyMovement2 : MonoBehaviour
{
     void Update () {
		float range =  5;
        GameObject player = GameObject.Find("Player");
        Rigidbody2D body = player.GetComponent<Rigidbody2D>(); 
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
		transform.position = new Vector2(transform.position.x, transform.position.y-range);
		}
		 if (Input.GetKeyUp(KeyCode.UpArrow))
        {
		transform.position = new Vector2(transform.position.x, transform.position.y+range);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
        {
		transform.position = new Vector2(transform.position.x+range, transform.position.y);
		}
		 if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
		transform.position = new Vector2(transform.position.x-range, transform.position.y);
		}
          /*  Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(string.Format("Co-ords of mouse is [X: {0} Y: {0}]", pos.x, pos.y));

            Tilemap tilemap = GetComponent<Tilemap>();
            Vector3Int cellPosition = tilemap.WorldToCell(new Vector3(pos.x,pos.y,0));
            transform.position = tilemap.GetCellCenterLocal(cellPosition);

            transform.Translate(transform.position-new Vector3(body.position.x, body.position.y, 0));
            //transform.Translate(Vector2.zero); 
        }
    */
	}
}