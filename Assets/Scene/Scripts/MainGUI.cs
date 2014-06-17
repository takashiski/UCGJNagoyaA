using UnityEngine;
using System.Collections;

public class MainGUI : MonoBehaviour {
	public GUIText timeGUI;
	public GUIText deathGUI;
	private string str;

	void Update () {
		GameManager.postTime += Time.deltaTime;
		timeGUI.text = "death : "+((int)GameManager.postTime).ToString();
		deathGUI.text = "time : "+GameManager.deathTime.ToString();
	}
}
