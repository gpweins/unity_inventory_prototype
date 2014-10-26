using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	public float turnSmoothing = 15f;
	
	private GameObject player;
	private Vector3 offset;
	private float horizontalAxis;
	private float verticalAxis;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag(Tags.player);
		offset = transform.position;
	}

	void Update()
	{
		// Cache the inputs.
		horizontalAxis = Input.GetAxis("Horizontal");
	}

	// LateUpdate is called once per frame after all Update events
	void LateUpdate () {
		MovementManagement(horizontalAxis);
	}

	void MovementManagement(float horizontal)
	{
		Vector3 newPosition = player.transform.position + offset;
		if(newPosition.z > -35.0)
		{
			transform.position = newPosition;

		}
		else
		{
			newPosition = new Vector3(newPosition.x, newPosition.y, -35);
		}

		transform.LookAt(player.transform);

	}

}
