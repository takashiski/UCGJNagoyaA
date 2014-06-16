using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
public class gimmick01 : MonoBehaviour {

	public float range = 2;
	public float moveSpeed = 1f;
	private Vector3 defaultPos;
	private float timeCount = 0;

	// Use this for initialization
	void Start () {
		defaultPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		timeCount+=Time.deltaTime;
		transform.localPosition = defaultPos + Vector3.forward * range *  Mathf.Sin(timeCount*moveSpeed);
	}
}
