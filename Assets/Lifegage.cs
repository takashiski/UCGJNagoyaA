using UnityEngine;
using System.Collections;

public class Lifegage : MonoBehaviour {

	int num;
	public Texture texture;
	float posX = 30;
	float posY = 30;
	float size = 40;
	void Awake()
	{
		num = GameManager.life;
	}
	// Update is called once per frame
	void OnGUI () {
		for(int i=0;i<num;i++)
		{
			GUI.Label(new Rect(posX + size * i,posY,size,size),texture);
		}
	}
}
