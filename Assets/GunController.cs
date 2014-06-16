using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {
	private GameObject player;
	public Transform target;
	public float distance;
	public float height;
	public Vector3 ofs = Vector3.zero;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
	}
	// Update is called once per frame
	void Update () {
		//transform.position = target.position + (Vector3.left * distance) + (Vector3.up * height);
		transform.position = player.transform.position + ofs;
		transform.rotation = player.transform.rotation;
	}
}
