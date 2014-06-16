using UnityEngine;
using System.Collections;

public class UnityChanMove : MonoBehaviour {
	public float speed = 3;
	public float JumpPower = 20;
	public float RotateY = 180;
	public AudioClip audioclip;

	private float time = 0;
	private bool isJumpCountFlag;
	private Vector3 direction = Vector3.zero;
	private CharacterController PlayerController;
	private Animator animator;
	private AudioSource audioSource;

	void Awake()
	{
		transform.position = GameManager.pos;
	}
	// Use this for initialization
	void Start () {
		PlayerController = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip = audioclip;
		isJumpCountFlag = false;
		transform.Rotate (Vector3.up*90);
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerController.isGrounded) {
			if (!isJumpCountFlag) {
				animator.SetBool ("isJumping", false);
			}
			float inputX = Input.GetAxis ("Horizontal");

			Vector3 inputDirection = (new Vector3 (inputX, 0, 0));

			direction = Vector3.zero;

			if (inputDirection.magnitude > 0.1) {
				transform.LookAt (transform.position + inputDirection);
				direction += transform.forward * speed;
				if (!isJumpCountFlag) {
					animator.SetBool ("isRunning", true);
				}
			}
			else if (!isJumpCountFlag) {
				animator.SetBool ("isRunning", false);
			}

			if (Input.GetButtonDown ("Jump")) {
				Debug.Log (transform.forward);
				isJumpCountFlag = true;
				animator.SetBool ("isJumping", true);
				animator.SetBool("isRunning",false);
			} 
			if (isJumpCountFlag) {
				time += Time.deltaTime;
				if (time >= 0.3) {
					audioSource.PlayOneShot(audioclip);
					isJumpCountFlag = false;
					time = 0;
					direction.y += JumpPower;
				}
			}
			else
			{
				direction.y += Physics.gravity.y;
			}
		}
		direction.z = 0;
		PlayerController.Move (direction * Time.deltaTime);
		//transform.position = new Vector3(transform.position.x,transform.position.y,0);
	}
	void OnControllerColliderHit(ControllerColliderHit c)
	{

		if(c.gameObject.tag == "Enemy")
		{
			GameManager.life --;
			if(GameManager.life <= 0)
			{
				Application.LoadLevel("GameOver");
			}
		}

	}
}
