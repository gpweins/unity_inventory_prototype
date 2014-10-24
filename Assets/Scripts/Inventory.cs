using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public List<Item> items = new List<Item>();
	private ItemDatabase database;

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start()
	{
		database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>();
	}

	/// <summary>
	/// Raises the GU event.
	/// </summary>
	void OnGUI()
	{
		for(int i = 0; i < items.Count; i++)
		{
			string labelText = items[i].name;
			if ( items[i].quantity > 1 )
			{
				labelText += " (" + items[i].quantity.ToString() + ")";
			}
			GUI.Label(new Rect(10, 30 * (i + 1), 200, 30), labelText);
		}

		if(GUI.Button(new Rect(220, 30, 160, 30), "Add Health Potion"))
		{
			Add("great_health_potion");
		}

		if(GUI.Button(new Rect(220, 70, 160, 30), "Add Health Potion"))
		{
			Add("health_potion");
		}
	}

	/// <summary>
	/// Gets the item.
	/// </summary>
	/// <returns>The item.</returns>
	/// <param name="slug">Slug.</param>
	Item GetItem(string slug)
	{
		return database.items.Find(x => x.slug == slug);
	}

	/// <summary>
	/// Add the specified newItem.
	/// </summary>
	/// <param name="newItem">New item.</param>
	void Add(Item newItem)
	{
		if(items.Contains(newItem))
		{
			Item item = items.Find(x => x.slug == newItem.slug);
			if (item.quantity < item.maxQuantity)
			{
				item.quantity++;
			}
		}
		else
		{
			items.Add(newItem);
		}
	}

	/// <summary>
	/// Add the specified item by the slug.
	/// </summary>
	/// <param name="slug">Slug.</param>
	void Add(string slug)
	{
		Item newItem = GetItem(slug);
		Add(newItem);
	}

}
