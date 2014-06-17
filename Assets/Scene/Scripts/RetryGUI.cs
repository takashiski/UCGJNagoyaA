using UnityEngine;
using System.Collections;

public class RetryGUI : MonoBehaviour {
	public Rect buttonPos = new Rect(0,0,400,400);

	void Awake()
	{
		buttonPos.y = (Screen.height)/2;
		buttonPos.x = (Screen.width-100)/2;
		GameManager.deathTime+=1;
	}
	void Update()
	{
		if(Input.GetButtonDown("Jump"))
		{
			Application.LoadLevel("Main");
		}

	}
	void OnGUI()
	{

		if(GUI.Button(buttonPos,"Retry?\n\nPush Button\nor Press\nSpace Key!"))
		{
			Application.LoadLevel("Main");

		}
	}



}
