using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public List<Item> items = new List<Item>();
	public ItemDatabase database;

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
		for(int i =0; i < items.Count; i++)
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
			Add(4);
		}
	}

	/// <summary>
	/// Gets the item.
	/// </summary>
	/// <returns>The item.</returns>
	/// <param name="id">Identifier.</param>
	Item GetItem(int id)
	{
		return database.items.Find(x => x.ID == id);
	}

	/// <summary>
	/// Add the specified newItem.
	/// </summary>
	/// <param name="newItem">New item.</param>
	void Add(Item newItem)
	{
		if(items.Contains(newItem))
		{
			Item item = items.Find(x => x.ID == newItem.ID);
			if (item.quantity < item.maxQuantity)
			{
				item.quantity++;
			}
		}
		else
		{
			newItem.quantity = 1;
			items.Add(newItem);
		}
	}

	/// <summary>
	/// Add the specified id.
	/// </summary>
	/// <param name="id">Identifier.</param>
	void Add(int id)
	{
		Item newItem = GetItem(id);
		Add(newItem);
	}

}
