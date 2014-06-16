using UnityEngine;
using System.Collections;

public class showTime : MonoBehaviour {
	public GUIText guitext;
	private string str;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GameManager.postTime += Time.deltaTime;
		str = "" + (int)GameManager.postTime;
		guitext.text = str;
	}
}
