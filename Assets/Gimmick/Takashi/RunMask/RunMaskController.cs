using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CharacterController))]
public class RunMaskController : MonoBehaviour {

	private Animator animator;
	private CharacterController controller;
	public float runSpeed = 5;
	private int dir = 1;
	private Vector3 dv = Vector3.zero;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		controller = GetComponent<CharacterController> ();
		animator.SetBool ("isRunning", true);
	}
	
	// Update is called once per frame
	void Update () {
		if(animator)
		{
			if(controller.isGrounded)
			{
				dv.x = runSpeed * dir;
			}
			dv+=Physics.gravity*Time.deltaTime;
			controller.Move(dv*Time.deltaTime);
		}
	}

	void OnControllerColliderHit(ControllerColliderHit c)
	{
		if(c.gameObject.tag=="Block")
		{
			transform.LookAt(transform.forward*-1);
			dir*=-1;
		}

	}
}
