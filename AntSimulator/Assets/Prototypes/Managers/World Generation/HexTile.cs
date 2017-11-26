using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HexTile : MonoBehaviour
{
	private float heightvalue; 
	//vars
	List<GameObject> objectlist;//This is the List of all actually existing Subobjects. This includes the Hex Base Tile but also Vegetation on top of this tile and similar
	Vector3 location; //defines where this Tile is based on. This is the center point on the upper surface
	Vector2 gridID; //defines the GridLocation this tile is on


public void updatePositions(Vector2 gridloc) //updates all Locations to this gridLocation
{
		gridID = gridloc;
		heightvalue= Random.Range (-100, 100) * 0.00125f; //currently generates random Height
		location = BasicTileLayer.getAbsolutePositionOfGridPosition (gridloc)+new Vector3(0,heightvalue,0);
		foreach (GameObject o in objectlist) {
			o.GetComponent<Transform> ().position=location;
		}
}

	public HexTile modifyToTile(GameObject tile)
	{
		List<GameObject> olist= new List<GameObject>();
		GameObject obj =Instantiate(tile);
		olist.Add(obj);

		//init
		this.objectlist=olist;
		this.location = new Vector3(0,0,0);
		this.gridID = new Vector2(0,0);

		return this;
	}
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		//not
	}
}