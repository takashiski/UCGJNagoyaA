using UnityEngine;
using System.Collections;

public class DeathLinePosition : MonoBehaviour {

	private GameObject Shachihoko;

	// Use this for initialization
	void Start () {
		Shachihoko = GameObject.Find ("shachihoko");
		transform.localPosition = new Vector3(0,0,-17.0f) + Shachihoko.transform.localPosition;
	}
}
