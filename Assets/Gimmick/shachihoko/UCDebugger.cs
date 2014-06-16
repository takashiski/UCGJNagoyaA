using UnityEngine;
using System.Collections;

public class UCDebugger : MonoBehaviour {

	private GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Debug.Log(player.transform.position);
	}
}
