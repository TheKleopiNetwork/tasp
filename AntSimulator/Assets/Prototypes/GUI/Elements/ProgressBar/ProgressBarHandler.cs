using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarHandler : MonoBehaviour {

	public double fillamount;
	public Image progressbarfront;
	
	// Update is called once per frame
	void Update () {
		updateFillAmount ();
	}
	public void updateFillAmount()
	{
		progressbarfront.fillAmount = (float) fillamount;
	}

	public void setFillAmount(double amount)
	{
		this.fillamount = amount;
	}
}
