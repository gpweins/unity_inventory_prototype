using UnityEngine;
using System.Collections;

[System.Serializable]
public class Item {

	public string name;
	public string slug;
	public string description;
	public Texture2D icon;
	public int quantity;
	public int maxQuantity;
	public int power;
	public int speed;
	public ItemType type;
	
	public enum ItemType {
		Armor,
		Jewel,
		Necklace,
		Potion,
		Quest,
		Ring,
		Shield,
		Weapon
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Item"/> class.
	/// </summary>
	/// <param name="itemName">Item name.</param>
	/// <param name="itemDesc">Item desc.</param>
	/// <param name="itemMaxQuantity">Item max quantity.</param>
	/// <param name="itemPower">Item power.</param>
	/// <param name="itemSpeed">Item speed.</param>
	/// <param name="itemType">Item type.</param>
	public Item(string itemName, string itemDesc, int itemMaxQuantity, int itemPower, int itemSpeed, ItemType itemType)
	{
		name = itemName;
		slug = Slugify();
		description = itemDesc;
		icon = Resources.Load<Texture2D>("Item Icons/" + slug);
		quantity = 1;
		maxQuantity = itemMaxQuantity;
		power = itemPower;
		speed = itemSpeed;
		type = itemType;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Item"/> class.
	/// </summary>
	public Item(){}

	/// <summary>
	/// Slugify this instance.
	/// </summary>
	private string Slugify()
	{
		return name.ToLower().Replace(' ', '_').Trim();
	}

}
