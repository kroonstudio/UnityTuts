using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
	public int slotsX, slotsY;
	public List<Item> inventory = new List<Item>();
	public List<Item> slots = new List<Item>();
	private ItemDatabase database;
	public bool showInventory;
	// Use this for initialization
	void Start () {

		for (int i=0; i< slotsX*slotsY; i++) 
		{
			slots.Add(new Item());
		}

		database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>();
		inventory.Add (database.items [0]);
		inventory.Add (database.items [1]);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("Inventory"))
		{
			showInventory = !showInventory;
		}

	}

	void OnGUI() {

		if (showInventory)
		{
			DrawInventory();
		}


		for (int i=0; i<inventory.Count; i++)
		{
			GUI.Label(new Rect(10, i * 20, 200, 40), inventory[i].itemName);
		}


	}

	void DrawInventory()
	{
		for (x	
	}

}
