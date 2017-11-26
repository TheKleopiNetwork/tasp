using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTileLayer : MonoBehaviour {

	public GameObject DefaultTile; //has to be connected with the Default Tile Prefab
	public GameObject DefaultTileRed; //has to be connected aswell

	private HexTile[][] hexmap; //our tilemap

	void Start () {
		//we dont lay tiles at start yet. The Game Controller will tell us when to generate the world
	}
	void Update () {
		//we do not update yet
	}
	public void generateWorld()
	{
		//will get more complex later
		flatmap(100,100);
	}
	void placeTile(HexTile tile,Vector2 gridloc) //places the Tile specified at the specified grid-Location. Also updates the hexmap with that tile
	{
		tile.updatePositions (gridloc);
	}
	void flatmap(int x,int y) //generates a simple flat map with specified size
	{
		for (int i = -(x / 2); i < x / 2; i++) {
			for (int j = -(y / 2); j < y / 2; j++) {
				HexTile tile = gameObject.AddComponent<HexTile>();
				placeTile (tile.modifyToTile ((Random.Range(1,3)==2)?DefaultTile:DefaultTileRed), new Vector2 (i, j));
			}
		}
	}
	public static Vector3 getAbsolutePositionOfGridPosition(Vector2 gridposition)
	{
		Vector3 xMod = new Vector3 (0.866f, 0f, 0f); 
		Vector3 yMod = new Vector3 (0f, 0f, 0.75f);

		Vector3 result = 
			new Vector3(0f,0f,0f)+ //origin
			gridposition.x*xMod+ //xoffset
			gridposition.y*yMod+ //yoffset
			(Mathf.Abs(gridposition.y%2))*(xMod/2); //xoffset if uneven 
		return result;
	}
}
