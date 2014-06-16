using UnityEngine;
using System.Collections;

public class water : MonoBehaviour {

	private GameObject Unitychan;
	private GameObject Shachihoko;
	private Vector3 water_position;
	private Vector3 move = new Vector3(0,0,1.0f);
	public Vector3 ofs = new Vector3(3,-5,0);
	public string shachiName = "Shachihoko";

	// Use this for initialization
	void Start () {
		water_position = transform.localPosition;
		Unitychan = GameObject.FindWithTag ("Player");
		Shachihoko = GameObject.Find (shachiName);
		transform.position = ofs + Shachihoko.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	}
}