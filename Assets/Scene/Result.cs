using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.guiText.text = "time : "+ GameManager.postTime.ToString();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
