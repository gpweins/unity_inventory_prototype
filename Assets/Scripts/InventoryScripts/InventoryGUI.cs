using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryGUI : MonoBehaviour {

	public GUISkin skin;

	private Inventory inventory;
	private bool isEnabled;
	private Vector2 scrollPosition = Vector2.zero;
	private int width;
	private int height;

	private int itemHeight;

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		inventory = GameObject.FindGameObjectWithTag(Tags.inventory).GetComponent<Inventory>();
		isEnabled = false;

		width = 780;
		height = 460;
		itemHeight = 60;
	}
	
	/// <summary>
	/// Update is called once per frame.
	/// </summary>
	void Update () {
		if(Input.GetButtonDown("Inventory"))
		{
			MonoBehaviour[] scriptComponents = GameObject.FindGameObjectWithTag(Tags.player).GetComponents<MonoBehaviour>();
			foreach(MonoBehaviour script in scriptComponents) {
				script.enabled = isEnabled;
			}
			isEnabled = !isEnabled;
		}
	}

	/// <summary>
	/// Raises the GU event.
	/// </summary>
	void OnGUI()
	{
		GUI.skin = skin;

		if(isEnabled) {
			DrawScreen(inventory.items);
		}
	}

	void DrawScreen(List<Item> items)
	{
		GUI.BeginGroup(new Rect(50, 50, width, height));
		GUI.Box(new Rect(0, 0, width, height), "Inventory");
		scrollPosition = GUI.BeginScrollView(new Rect(10, 50, width - 10, height - 50), scrollPosition, new Rect(0, 0, width - 30, (items.Count * itemHeight)));
		for(int i = 0; i < items.Count; i++)
		{
			DrawItem(items[i], i);
		}
        GUI.EndScrollView();

        GUI.EndGroup();
    }
    
    void DrawItem(Item item, int index)
	{
		string labelQty = "";
		if(item.maxQuantity > 1)
		{
			labelQty = item.quantity.ToString() + "/" + item.maxQuantity.ToString();
		}

		GUI.Box(new Rect(15, (index * itemHeight) - 5, 700, 50), "");
		GUI.Label(new Rect(20, (index * itemHeight) , 40, 40), item.icon);
		if(item.type == Item.ItemType.Quest)
		{
			GUI.Label(new Rect(40, (index * itemHeight) + 20 , 20, 20), "Q", "Quest Label");
		}
		GUI.Label(new Rect(80, (index * itemHeight), 610, 20), item.name, "Item Title");
		GUI.Label(new Rect(80, (index * itemHeight) + 20, 610, 20), item.description, "Item description");
		GUI.Label(new Rect(630, (index * itemHeight), 40, 20), labelQty);

		if(item.type == Item.ItemType.Potion)
		{
	        if(GUI.Button(new Rect(630, (index * itemHeight) + 20, 40, 20), "Use"))
			{
				if(item.quantity > 1)
				{
					item.quantity--;
				}
				else
				{
					inventory.Remove(item);
				}
			}
		}
	}
	
}
