using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public List<Item> items = new List<Item>();
	private ItemDatabase database;
	private bool isVisible;

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start()
	{
		database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>();

		Add("bat_wing");
		Add("bow");
		Add("map");
		Add("leather_armor");
		Add("small_health_potion", 97);
		Add("health_potion", 50);
		Add("great_health_potion", 10);
		Add("diamond", 5);
		Add("wooden_shield");
		Add("power_ring");
		Add("gold_necklace");
		Add("saffire_necklace");
		Add("book");
	}

	/// <summary>
	/// Gets the item by the index.
	/// </summary>
	/// <returns>The item.</returns>
	/// <param name="index">Index.</param>
	public Item GetItem(int index)
	{
		if(index < database.items.Count)
		{
			return database.items[index];
        }
		return new Item();
	}

	/// <summary>
	/// Gets the item by the slug.
	/// </summary>
	/// <returns>The item.</returns>
	/// <param name="slug">Slug.</param>
	public Item GetItem(string slug)
	{
		return database.items.Find(x => x.slug == slug);
	}

	/// <summary>
	/// Add the specified item.
	/// </summary>
	/// <param name="item">New item.</param>
	public void Add(Item item)
	{
		Add(item, 1);
	}

	/// <summary>
	/// Add the specified item and quantity.
	/// </summary>
	/// <param name="item">New item.</param>
	/// <param name="quantity">Quantity.</param>
	public void Add(Item item, int quantity)
	{
		if(quantity > item.maxQuantity)
		{
			quantity = item.maxQuantity;
		}

		if(items.Contains(item))
		{
			if ((item.quantity + quantity) < item.maxQuantity)
			{
				item.quantity += quantity;
            }
			else
			{
				item.quantity = item.maxQuantity;
			}
        }
        else
        {
			item.quantity = quantity;
            items.Add(item);
        }
	}

	/// <summary>
	/// Add the specified item by the index on the database.
	/// </summary>
	/// <param name="index">Index.</param>
	public void Add(int index)
	{
		Item item = GetItem(index);
		if(item != null) {
            Add(item);
        }
    }
    
    /// <summary>
	/// Add the specified item by the slug.
	/// </summary>
	/// <param name="slug">Slug.</param>
	public void Add(string slug)
	{
		Item item = GetItem(slug);
		if(item != null) {
			Add(item);
		}
	}

	/// <summary>
	/// Add the specified item by the slug with a defined quantity.
	/// </summary>
	/// <param name="slug">Slug.</param>
	/// <param name="quantity">Quantity.</param>
	public void Add(string slug, int quantity)
	{
		Item item = GetItem(slug);
		if(item != null) {
			Add(item, quantity);
        }
    }

}
