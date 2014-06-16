using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {


	void OnTriggerEnter(Collider c)
	{
		if(c.tag == "Player")
		{
			//Send this.transform.position to GameManager
			GameManager.pos = new Vector3(transform.position.x,transform.position.y,0);
		}
	}
}
