using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MouseTileMov : MonoBehaviour
{
     void Update () {
        GameObject player = GameObject.Find("Player");
        Rigidbody2D body = player.GetComponent<Rigidbody2D>(); 
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(string.Format("Co-ords of mouse is [X: {0} Y: {0}]", pos.x, pos.y));

            Tilemap tilemap = GetComponent<Tilemap>();
            Vector3Int cellPosition = tilemap.WorldToCell(new Vector3(pos.x,pos.y,0));
            transform.position = tilemap.GetCellCenterWorld(cellPosition);

            transform.Translate(transform.position-new Vector3(body.position.x, body.position.y, 0));
            transform.Translate(Vector2.zero); 
        }
    }
}

