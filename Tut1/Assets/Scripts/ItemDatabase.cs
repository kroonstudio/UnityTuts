using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {

	public List<Item> items = new List<Item>();

	void Start()
	{
		items.Add(new Item("Potion", 0, "Just as potion", 0,0, Item.ItemType.Consumable));
		items.Add(new Item("Sword", 0, "Big Sword", 0,0, Item.ItemType.Weapon));
	}

}
