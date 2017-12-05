using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add1SciencePoints : MonoBehaviour {

	public StorageHolder storage;
	// Use this for initialization

	public void AddScience(){	
	storage.addScience (1);
	}
}
