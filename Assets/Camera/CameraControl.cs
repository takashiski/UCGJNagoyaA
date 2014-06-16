using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public Transform target;
	public Vector3 cameraPos = Vector3.zero; 
	public float distance = 4.0f;
	public float height = 2.0f;




	void Update () 
	{
		transform.position = target.position + cameraPos;
	//	transform.LookAt (target);
	}
}
