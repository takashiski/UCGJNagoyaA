using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {


	void OnTriggerEnter(Collider c)
	{
		if(c.tag == "Player")
		{
			Application.LoadLevel("GameOver");
		}
	}
}
