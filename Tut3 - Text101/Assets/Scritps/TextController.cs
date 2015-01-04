using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	public enum State {cell, sheets_o, mirror, lock_0, sheets_1, cell_mirror, lock_1, freedom};
	private State currentState; 
	// Use this for initialization
	void Start () {
		currentState =  State.cell;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (currentState == State.cell)
		{
			CellState();
		}
		if (currentState == State.sheets_o)
		{
			Sheets_0();
		}
		if (currentState == State.mirror)
		{
			Mirror();
		}
		if (currentState == State.cell_mirror)
		{
			CellMirror();
		}
	
	}
	
	void CellState() 
	{
		text.text = "You are in a cell, an old dirty" +
					"stinking cell. You see sheets, mirron, and a lock." +
					"What would you want to do?\n\n" +
					"Press S to look at sheets, L to look at the door, M to look at the mirror";
	
		if (Input.GetKeyDown(KeyCode.S))
		{
			currentState = State.sheets_o;
		}
		if (Input.GetKeyDown(KeyCode.L))
		{
			currentState = State.lock_0;
		}
		if (Input.GetKeyDown(KeyCode.M))
		{
			currentState = State.mirror;
		}
	}
	
	void Sheets_0() 
	{
		text.text = "Just all dirty sheets, nothing here\n\n" +
					"Press R to go back to cell";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = State.cell;
		}
	}
	
	void Lock_0() 
	{
		text.text = "Just all dirty sheets, nothing here\n\n" +
			"Press R to go back to cell";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = State.cell;
		}
	}
	
	void Mirror () 
	{
		text.text = "Just all dirty sheets, nothing here\n\n" +
			"Press O to take the mirror, Press R to go back to cell";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = State.cell;
		}
		if (Input.GetKeyDown(KeyCode.O))
		{
			currentState = State.cell_mirror;
		}	
	}
	
	void CellMirror () 
	{
		text.text = "now i've got the mirror, i might use it\n\n" +
			"Press L to unlock the door, Press S to viewSheets";
		
		if (Input.GetKeyDown(KeyCode.L))
		{
			currentState = State.freedom;
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			currentState = State.sheets_1;
		}	
	}
	
	
	
	
	
	
}
