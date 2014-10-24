using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {

	public List<Item> items = new List<Item>();

	void Start()
	{
		items.Add(
			new Item(
				"Bat Wing", 
				"Quest item", 
				1, 
				0, 
				0,
				Item.ItemType.Quest
			)
		);

		items.Add(
			new Item(
				"Book", 
				"Quest item", 
				1, 
				0, 
				0,
				Item.ItemType.Quest
			)
		);

		items.Add(
			new Item(
				"Bow", 
				"A simple bow", 
				1, 
				15, 
				7,
				Item.ItemType.Weapon
			)
		);

		items.Add(
			new Item(
				"Diamond", 
				"A valuable gem", 
				99, 
				0, 
				0,
				Item.ItemType.Jewel
			)
		);

		items.Add(
			new Item(
				"Gold Necklace", 
				"A beatiful pendant", 
				1, 
				0, 
				0,
				Item.ItemType.Necklace
			)
		);

		items.Add(
			new Item(
				"Great Health Potion", 
				"Cures serious wounds", 
				99, 
				50, 
				0,
				Item.ItemType.Potion
			)
		);

		items.Add(
			new Item(
				"Health Potion", 
				"Cures wounds", 
				99, 
				25, 
				0,
				Item.ItemType.Potion
			)
		);

		items.Add(
			new Item(
				"Leather Armor", 
				"This is rhino's leather?", 
				1, 
				4, 
				-2,
				Item.ItemType.Armor
			)
		);

		items.Add(
			new Item(
				"Map", 
				"It's upside down, genius!", 
				1, 
				0, 
				0,
				Item.ItemType.Quest
			)
		);

		items.Add(
			new Item(
				"Power Ring", 
				"One ring to teach them all a lesson!", 
				1, 
				15, 
				5,
				Item.ItemType.Ring
			)
		);

		items.Add(
			new Item(
				"Prison Key", 
				"Open the prison door", 
				1, 
				0, 
				0,
				Item.ItemType.Quest
			)
		);

		items.Add(
			new Item(
				"Reinforced Wooden Shield", 
				"This is... Sparta!", 
				1, 
				50, 
				-4,
				Item.ItemType.Shield
			)
		);

		items.Add(
			new Item(
				"Saffire Necklace", 
				"Your mom would love it!", 
				1, 
				3, 
				1,
				Item.ItemType.Necklace
			)
		);

		items.Add(
			new Item(
				"Small Health Potion", 
				"For your litle scratches", 
				99, 
				5, 
				0,
				Item.ItemType.Potion
			)
		);

		items.Add(
			new Item(
				"Steel Armor", 
				"I'm Iron Man!", 
				1, 
				30, 
				-5,
				Item.ItemType.Weapon
			)
		);

		items.Add(
			new Item(
				"Steel Sword", 
				"The first cut is the deepest!", 
				1, 
				25, 
				5,
				Item.ItemType.Weapon
			)
		);

		items.Add(
			new Item(
				"Wooden Shield", 
				"It will break... soon!", 
				1, 
				2, 
				-1,
				Item.ItemType.Armor
			)
		);
	}
	
}
