using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	KeyCode camera_upKey,camera_downKey,camera_rightKey,camera_leftKey;

	float camera_movementspeed;
	// Use this for initialization
	void Start () {
		camera_upKey=KeyCode.W;
		camera_downKey=KeyCode.S;
		camera_rightKey=KeyCode.D;
		camera_leftKey=KeyCode.A;
		camera_movementspeed = 2;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (camera_upKey)) {
			transform.Translate (transform.InverseTransformDirection(new Vector3 (0, 0, camera_movementspeed)));
		}
		if (Input.GetKey (camera_downKey)) {
			transform.Translate (transform.InverseTransformDirection(new Vector3 (0, 0, -camera_movementspeed)));
		}
		if (Input.GetKey (camera_rightKey)) {
			transform.Translate (transform.InverseTransformDirection(new Vector3 (camera_movementspeed,0,0)));
		}
		if (Input.GetKey (camera_leftKey)) {
			transform.Translate (transform.InverseTransformDirection(new Vector3 (-camera_movementspeed,0,0)));
		}
			transform.Translate(0,0,Input.GetAxis("Mouse ScrollWheel") * camera_movementspeed); 
	}
}
