using UnityEngine;
using System.Collections;

public class HashIDs : MonoBehaviour {

	public int deadBool;
	public int shoutingBool;
	public int sneakingBool;
	public int speedFloat;

	public int dyingState;
	public int locomotionState;
	public int sneakState;

	public int shoutState;


	void Awake()
	{
		deadBool = Animator.StringToHash("Dead");
		deadBool = Animator.StringToHash("Shouting");
		deadBool = Animator.StringToHash("Sneaking");
		deadBool = Animator.StringToHash("Speed");

		dyingState = Animator.StringToHash("Base Layer.Dying");
		locomotionState = Animator.StringToHash("Base Layer.Locomotion");
		sneakState = Animator.StringToHash("Base Layer.Sneak");

		shoutState = Animator.StringToHash("Shouting.Shout");
	}

}
