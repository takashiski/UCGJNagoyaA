using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {
	
	private GameObject Water;
	private GameObject Unitychan;


	// Use this for initialization
	void Start (){
		Water = GameObject.Find ("Water Fountain");
		Unitychan = GameObject.FindWithTag ("Player");
		transform.localPosition = new Vector3(-65.5f,3.0f,-0.8f) + Water.transform.localPosition;
	}
	
	// Update is called once per frame
	void OnTriggerStay(Collider c){
		if(c.tag == "Player")
			Unitychan.transform.localPosition += new Vector3 (0,0,-1.0f);
	}
}
