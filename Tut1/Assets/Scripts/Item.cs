using UnityEngine;
using System.Collections;


// Here we are creatin the item
//eg. what kind is it, name, icon etc.
[System.Serializable]
public class Item {


	public string itemName;
	public int itemID;
	public string itemDesc;
	public Texture2D itemIcon;
	public int itemPower;
	public int itemSpeed;
	public ItemType itemType; 


	public enum ItemType {
		Weapon, 
		Consumable, 
		Quest
	}

	//Construction for Item Class
	//we are using it so we dont have to use the inspector
	//to add new items to database
	//When ever Item Class is call, everything what is in the
	//construscots is call as well

	public Item(string name, int id, string desc, int power, int speed, ItemType type)
	{
		itemName = name;
		itemID = id;
		itemDesc = desc;
		itemPower = power;
		itemSpeed = speed;
		itemType = type;
		//Calling in the icons from the folder
		//icons name are eqal to item names
		itemIcon = Resources.Load<Texture2D> ("Item Icons/" + name);

	}

	//COnstruction of Item with no arguments
	//this one we need to create slots

	public Item ()
	{

	}


}
