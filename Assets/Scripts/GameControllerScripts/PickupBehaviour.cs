using UnityEngine;
using System.Collections;

public class PickupBehaviour : MonoBehaviour {

	public string itemSlug;
	public int quantity;

	private GameObject player;
	private Inventory inventory;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag(Tags.player);
		inventory = GameObject.FindGameObjectWithTag(Tags.inventory).GetComponent<Inventory>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.Equals(player)) {
			PickUp();
		}

	}

	void PickUp()
	{
		inventory.Add(itemSlug, quantity);
		Destroy(this.gameObject);
	}
}
