using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    GameObject[,] Map;

	// Use this for initialization
	void Start () {
        Map = new GameObject[2,2];
        Debug.Log(Map);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
