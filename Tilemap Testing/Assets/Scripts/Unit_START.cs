using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System;
public class Unit_START : MonoBehaviour
{
     void Start() {
		float range =  5;
        GameObject player = GameObject.Find("Player");
		float x = (float)2.5;
		transform.position = new Vector2(x, x);
	}
}