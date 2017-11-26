using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColonyTaskManager : MonoBehaviour {

	public Colony colony;
	List<Task> tasklist;

	public ColonyTaskManager(Colony c)
	{
		this.colony = c;
	}

	public enum TaskPriorityOption
	{
		QUEUE
	}

	// Use this for initialization
	void Start () {
		tasklist = new List<Task> ();
	}
	//Assigns a new Task
	public void assign (Task task)
	{
		tasklist.Add (task);
	}
	//Returns a task
	public Task take(List<TaskPriorityOption> options)
	{
		if(tasklist.Count>0){
			List<Task> filteredlist=Filter(options);
			return filteredlist[1];

			}
		else
		//no tasks assigned
			return new NOPTask();

	}
	public List<Task> Filter(List<TaskPriorityOption> options)
	{
		//TODO implement
		return null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
