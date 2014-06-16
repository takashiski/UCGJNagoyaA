using UnityEngine;
using System.Collections;

public class ClearScript : MonoBehaviour {

	void OnTriggerEnter(Collider c)
	{
		if(c.tag == "Player")
		{
			Application.LoadLevel("GameClear");
		}

	}
}
