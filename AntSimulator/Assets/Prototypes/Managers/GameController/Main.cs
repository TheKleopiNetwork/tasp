using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	public BasicTileLayer worldgen;

	// Use this for initialization
	void Awake () {
		worldgen.generateWorld ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
