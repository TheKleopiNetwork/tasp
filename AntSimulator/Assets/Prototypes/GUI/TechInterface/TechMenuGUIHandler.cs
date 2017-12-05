using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechMenuGUIHandler : MonoBehaviour {

	public ResearchManager manager;
	public ProgressBarHandler progressBar;
	
	// Update is called once per frame
	void Update () {
		//we need to update the progressbar to show the current research
		updateProgressBar();
	}
	void updateProgressBar()
	{
		progressBar.setFillAmount (manager.getCurrentResearch ().alreadyResearchedAmount / manager.getCurrentResearch ().researchCost);
	}
}
