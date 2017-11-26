using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Research : MonoBehaviour
{
	public ResearchManager manager;
	public bool isFinished;
	public int researchCost;
	public double alreadyResearchedAmount;
	public bool active;
	public string resname;
	public string description;
	public List<Research> dependencies = new List<Research>();
	public Effect effect;

	public void addResearchPoints(double points)
	{
		if (isFinished) {
			Debug.LogError ("We can not continue research the research " + getName () + ": It is already finished!");
			return;
		}
		if (!active) {
			Debug.LogError ("We can not continue research the research " + getName () + ": It is not enabled!");
			return;
		}
		alreadyResearchedAmount += points;
		if (alreadyResearchedAmount > researchCost) {
			isFinished = true;
			manager.finishResearch (this);
		}
	}
	public string getName()
	{
		return name;
	}













}


