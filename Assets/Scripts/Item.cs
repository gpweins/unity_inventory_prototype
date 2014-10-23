using UnityEngine;
using System.Collections;

[System.Serializable]
public class Item {

	public string name;
	public int ID;
	public string description;
	public Texture2D icon;
	public int power;
	public int speed;
	public ItemType type;
	
	public enum ItemType {
		Consumable,
		Equipable,
		Quest
	}

}
