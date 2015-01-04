using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;
	// Use this for initialization
	void Start () 
	{
		max = max + 1;
		StartGame();

	}
	
	void StartGame() 
	{
		Debug.Log ("==========================");
		print ("Zdravo ljubavi moja. Ja sam svemocni SKOBO i mogu da ti citam misli. Evo kako: Zamisli jedan broj izmedju " + min + " i " + max);
		print ("Da li je broj koji si zamislila manji ili veci od " + guess);
		print ("UP ARROW = VECI, DOWN = MANJI, ENTER = TO JE BROJ");
	}
	
	void NextGuess()
	{
		guess = (max + min) / 2;
		print ("manji ili veci od " + guess);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			NextGuess();
	 	}
	 	else if (Input.GetKeyDown(KeyCode.DownArrow))
	 	{
			max = guess;
			NextGuess();
	 	} 
	 	else if (Input.GetKeyDown(KeyCode.Return))
	 	{
			print ("HAHAH JA SAM POBEDIO");
			guess = 500;
			max = 1000;
			StartGame();
	 	}
	 	
	}
}
