using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {
	public GameObject block;
	private GameObject trap;

	void Start()
	{
		trap = GameObject.Find ("Cube"); 
	}
	void OnTriggerEnter(Collider c)
	{
		Debug.Log (c.name);
		trap.rigidbody.isKinematic = false;
		trap.rigidbody.velocity =(Vector3.forward * -50);
	}
}
