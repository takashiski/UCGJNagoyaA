using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Animator))]

public class UnityMaskController : MonoBehaviour {

	private Animator animator;
	private CharacterController controller;
	private Rigidbody rb;
	private AnimatorStateInfo currentState;
	private AnimatorStateInfo prevState;
	private float x,y,prevx;
	public float jumpPower = 3;
	public float walkSpeed = 3;
	private Vector3 direction;
	private float jumpCounter,kickCounter;
	public float jumpLimit = 2;
	public float kickLimit = 2;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
		controller = GetComponent<CharacterController> ();
		currentState = animator.GetCurrentAnimatorStateInfo (0);
		prevState = currentState;
		transform.Rotate (0,90,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(animator)
		{
			if(controller.isGrounded){
				if(!animator.IsInTransition(0)&&(jumpCounter > jumpLimit||kickCounter > kickLimit)){
					animator.SetBool("isJumping",false);
					animator.SetBool("isKicking",false);
					if(Input.GetButtonDown("Fire1"))
					{
						kickCounter = 0;
						animator.SetBool("isKicking",true);
						animator.SetBool("isRunning",false);
						animator.SetBool("isJumping",false);

					}
					if(Input.GetButtonDown("Jump"))
					{
						jumpCounter = 0;
						animator.SetBool("isRunning",false);
						animator.SetBool("isJumping",true);
						direction.y += jumpPower;
						Debug.Log ("Jump!");
					}
					else if(!animator.GetBool("isJumping")){
						x = Input.GetAxisRaw("Horizontal");
						if(x != 0)
						{
							animator.SetBool("isRunning",true);
						}
						else 
							animator.SetBool("isRunning",false);
						direction.x = x*walkSpeed;
					}
				}
				else
				{
					kickCounter+=Time.deltaTime;
					jumpCounter+=Time.deltaTime;
				}
			}
			direction += Physics.gravity*Time.deltaTime;
			controller.Move(direction * Time.deltaTime);
		}
	}
}
