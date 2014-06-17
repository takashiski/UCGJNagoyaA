using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour {
	public Rect buttonPos = new Rect(0,0,400,400);
	
	void Awake()
	{
		buttonPos.y = (Screen.height)/2;
		buttonPos.x = (Screen.width-100)/2;
	}
	void Start () {
		this.guiText.text = "time : "+ GameManager.postTime.ToString()+"\ndeath : " + GameManager.deathTime.ToString();	
	}

	void Update()
	{
		if(Input.GetButtonDown("Jump"))
		{
			GameManager.resetParam();
			Application.LoadLevel("Title");
		}
		
	}
	void OnGUI()
	{
		if(GUI.Button(buttonPos,"Push Button\nor Press\nSpace Key!"))
		{
			GameManager.resetParam();
			Application.LoadLevel("Title");
		}
	}
}
