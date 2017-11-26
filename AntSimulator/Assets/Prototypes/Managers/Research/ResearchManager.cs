using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResearchManager : MonoBehaviour {

	//Multiplied 50 times a second to the science amount. Handled by the storageManager. Default: 0.99996 to reduce by ~10% a minute
	public static double SCIENCEDECAYMULTIPLIER = 0.99996;

	List<Research> researches= new List<Research>();
	Research currentResearch;
	// Use this for initialization
	void Start () {
		loadResearches ();
		loadCurrentResearch();
	}
	void loadCurrentResearch()
	{
		//TODO: implement
	}
	void loadResearches()
	{
		//TODO: implement
		loadTestResearch();
	}

	public void finishResearch(Research res)
	{
		//TODO: implement
	}

	void unfinishResearch(Research res)
	{
		//TODO: implement
	}

	public Research modifyToDefaultResearch(Research research,ResearchManager manager,string name,string descr,List<Research> dependencies,int cost,Effect effect)
	{
		research.active = false;
		research.alreadyResearchedAmount = 0;
		research.dependencies = dependencies;
		research.isFinished = false;
		research.researchCost = cost;
		research.effect = effect;
		research.resname = name;
		research.description = descr;
		research.manager = manager;
		return research;
	}

	void setCurrentResearch(Research res)
	{
		currentResearch = res;
	}

	Research getCurrentResearch()
	{
		return currentResearch;
	}
	public void loadTestResearch()
	{
		Research research = gameObject.AddComponent<Research>();
		research = modifyToDefaultResearch (research,this,"TestResearch","To test the research System",new List<Research>(),10,null);
		researches.Add (research);
	}

}
