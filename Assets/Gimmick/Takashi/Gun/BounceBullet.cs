using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class BounceBullet : MonoBehaviour {
	public float bulletSpeed = 5;
	private Vector3 direction;
	private GameObject player;

	void Awake()
	{
		player = GameObject.FindWithTag("Player");
		direction = player.transform.forward;
	}

	void Update () {
		rigidbody.velocity = direction * bulletSpeed;
	}
	void OnCollisionEnter(Collision c)
	{
		if(c.gameObject.tag == "Enemy")
			Destroy (c.gameObject);
	}
}
