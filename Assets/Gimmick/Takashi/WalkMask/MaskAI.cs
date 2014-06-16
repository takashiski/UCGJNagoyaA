using UnityEngine;
using System.Collections;

public class MaskAI : MonoBehaviour {

	private GameObject Unitychan;
	private float speed = 0.03f;

	// Use this for initialization
	void Start () {
		Unitychan = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(Unitychan.transform.localPosition);
		if (Unitychan.transform.localPosition.x < transform.localPosition.x) {
			transform.localPosition -= new Vector3 (speed, 0.0f, 0.0f);
		} else {
			transform.localPosition += new Vector3 (speed, 0.0f, 0.0f);
		}
	}
}