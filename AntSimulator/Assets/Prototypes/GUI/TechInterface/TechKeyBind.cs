using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechKeyBind : MonoBehaviour {

	public GameObject techmenu;
	// Use this for initialization
	void Start () {
		techmenu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			toggleTechMenu ();
		}
	}

	void toggleTechMenu()
	{
		print ("Debug: toggled techmenu");	
		techmenu.SetActive(!techmenu.activeInHierarchy);
	}


}
