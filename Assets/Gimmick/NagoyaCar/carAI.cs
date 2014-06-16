using UnityEngine;
using System.Collections;

public class carAI : MonoBehaviour {

	private GameObject Unitychan;
	private GameObject Car;
	private float carPosition;
	private Vector3 move = new Vector3(0.0f,0.0f,0.0f);
	private bool go_flag = false;
	private float counter = 0.0f;

	// Use this for initialization
	void Start () {
		Car = GameObject.Find ("FrenchClassicCar");
		Unitychan = GameObject.FindWithTag ("Player");
	
	}
	
	// Update is called once per frame
	void Update () {
		carPosition = transform.localPosition.x;
		if (carPosition + 5 < Unitychan.transform.localPosition.x) 
			go_flag = true;
		if(go_flag){
			counter += 0.000075f;
			//Debug.Log(counter);
			move += new Vector3(0f + counter, 0.0f, -0.0005f);
			transform.localPosition += move;
		}
	
		if(transform.localPosition.z < -10) Object.Destroy(Car);
	}
}
