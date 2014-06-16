using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Animator))]

public class WalkMaskController : MonoBehaviour {

	private Animator animator;
	private CharacterController controller;
	private GameObject player;
	private float x,y;
	private Vector3 dv;
	private float dir = 1;
	public float walkSpeed = 2;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		controller = GetComponent<CharacterController> ();
		player = GameObject.FindWithTag("Player");
		animator.SetBool ("isWalking", true);
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(new Vector3(player.transform.position.x,transform.position.y,transform.position.z));
		if(animator)
		{
			if(controller.isGrounded){
				dv.x = walkSpeed*dir;
			}
			dv += Physics.gravity*Time.deltaTime;
			controller.Move(dv * Time.deltaTime);
		}

	}
	/*
	void OnControllerColliderHit(ControllerColliderHit c)
	{

		if(c.gameObject.tag == "Block")
		{
			transform.LookAt (transform.forward*-1);
			dir*=-1;
		}
	}
	*/
}
