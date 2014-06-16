using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {
	public Rect buttonPos = new Rect(400,240,100,100);
	void Awake()
	{
		buttonPos = new Rect((Screen.width-100)/2,(Screen.height-100)/2,100,100);
	}
	void OnGUI()
	{

		if(GUI.Button(buttonPos,"START"))
		{
			Application.LoadLevel("Main");
		}

	}
}
