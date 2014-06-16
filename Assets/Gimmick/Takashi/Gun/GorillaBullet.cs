using UnityEngine;
using System.Collections;

public class GorillaBullet : MonoBehaviour {

	private Rigidbody rb;
	private GameObject player;
	public float power = 5;

	void Awake()
	{
		rb = this.gameObject.rigidbody;
		player = GameObject.FindWithTag("Player");
	}
	void FixedUpdate()
	{
		rb.velocity = player.transform.forward * power * -1+Vector3.up*-1f;
	}
}
