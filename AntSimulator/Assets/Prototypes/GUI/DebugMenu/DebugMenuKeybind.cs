using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMenuKeybind : MonoBehaviour {

	public GameObject debugmenu;
	// Use this for initialization
	void Start () {
		debugmenu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F3)) {
			toggleDebugMenu ();
		}
	}
	void toggleDebugMenu()
	{
		print ("Debug: toggled debugmenu");	
		debugmenu.SetActive(!debugmenu.activeInHierarchy);
	}
}
