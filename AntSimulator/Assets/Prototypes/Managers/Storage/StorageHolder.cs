using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorageHolder : MonoBehaviour {

	public double food;
	public double minerals;
	public double science;
	public Text storageContentString;

	// Use this for initialization
	void Start () {
		food = 0;
		minerals = 0;
		science = 1;
	}
	// FixedUpdate is called 50 times a second
	void FixedUpdate () {
		//for researching we deduct 10% of the current research storage per minute to simulate radioactive decay (and keep research limited) -> roughly 0.99996 as multiplicator per game-tick
		//TODO: performance!
		science*=ResearchManager.SCIENCEDECAYMULTIPLIER;
		if (science < 1) {
			//in case player cant get research resources make sure he is able to conduct research at minimal rate
			science = 1;
		}
	}
	void Update()
	{
		//update the text
		storageContentString.text = "Storage: \n" +
		"Food: " + food + "\n" +
		"Minerals: " + minerals + "\n" +
		"Science: " + science + "\n";
	}

	public void addFood(double amount)
	{
		food += amount;
	}
	public void addMinerals(double amount)
	{
		minerals += amount;
	}
	public void addScience(double amount)
	{
		science += amount;
	}
}
