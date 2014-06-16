using UnityEngine;
using System.Collections;

public class ebimove : MonoBehaviour {

	private GameObject Unitychan;
	private float nowPosition;
	private float speed = 0.01f;

	// Use this for initialization
	void Start () {
		Unitychan = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		nowPosition = transform.localPosition.x;

		if (nowPosition <= Unitychan.transform.localPosition.x) {
			transform.localPosition += new Vector3(speed,0,0);
		}else transform.localPosition -= new Vector3(speed,0,0);
	}
}
