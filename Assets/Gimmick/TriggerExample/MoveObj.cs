using UnityEngine;
using System.Collections;

public class MoveObj : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		rigidbody.velocity = Vector3.right*2;
//		transform.Translate (Vector3.right*Time.deltaTime);
	}
}
