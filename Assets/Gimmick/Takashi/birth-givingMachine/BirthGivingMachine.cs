using UnityEngine;
using System.Collections;

public class BirthGivingMachine : MonoBehaviour {

	public GameObject man;
	public float manPerSec = 2f;
	public Vector3 ofs = Vector3.up*-1;
	public Vector3 direction = Vector3.zero;
	public float power = 10;

	private float counter = 0;
	private GameObject player;

	void Awake()
	{
		player = GameObject.FindWithTag("Player");
		
	}

	void FixedUpdate()
	{
		counter += Time.fixedDeltaTime;
		if(counter > manPerSec)
		{
			GameObject obj = Instantiate (man, transform.position+ofs+Vector3.right*Random.Range(-3,3), player.transform.rotation) as GameObject;
			obj.transform.Rotate(0,180,0);
			Destroy (obj, 10f);
			counter = 0;
		}

	}

}
