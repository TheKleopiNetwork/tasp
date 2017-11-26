using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : MonoBehaviour {

	public double stat_hp,stat_maxhp,stat_attack,stat_defensePower,stat_movement_speed,stat_carry_capacity,stat_spotting_range,stat_regeneration_power; //expandable

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (stat_hp <= 0.0)
			die ();
		if (stat_hp < stat_maxhp)
			stat_hp = (double) Mathf.Min((float)stat_maxhp, (float)(stat_hp + stat_regeneration_power));
	}

	void die(){
		//die: remove it, drop carried food etc
	}
	void damage(double amount_of_damage){
		//apply damage; might change to evaluate attacker instead of damage
	}

}
