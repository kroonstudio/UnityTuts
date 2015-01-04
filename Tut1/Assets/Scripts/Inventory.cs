using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
	public int slotsX, slotsY;
	public GUISkin skin;
	public List<Item> inventory = new List<Item>();
	public List<Item> slots = new List<Item>();
	private ItemDatabase database;
	public bool showInventory;
	// Use this for initialization
	void Start () {

		for (int i=0; i< slotsX*slotsY; i++) 
		{
			slots.Add(new Item());
			inventory.Add(new Item());
		}

		database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>();
		inventory [0] = database.items[0];
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.I))
		{
			showInventory = !showInventory;
		}

	}

	void OnGUI() {

		GUI.skin = skin;
		if (showInventory)
		{
			DrawInventory();
		}


		for (int i=0; i<inventory.Count; i++)
		{
			//GUI.Label(new Rect(10, i * 20, 200, 40), inventory[i].itemName);
		}


	}

	void DrawInventory()
	{
		int i = 0;
		for ( int x = 0; x < slotsX; x++)
		{
			for (int y = 0; y < slotsY; y++)

			{	
				Rect slotsRect = new Rect (x *65.0f, y * 65.0f, 60.0f, 60.0f);
				GUI.Box(slotsRect, "", skin.GetStyle("Slot"));
				slots[i] = inventory[i];
				if (slots[i].itemName != null) 
				{
					GUI.DrawTexture(slotsRect, slots[i].itemIcon);
				}
				i++;

			}
		}
	}

}
