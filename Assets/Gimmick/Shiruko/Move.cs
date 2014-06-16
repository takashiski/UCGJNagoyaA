using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
	public const int SPEED = 3;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float axisValue = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * axisValue * SPEED * Time.deltaTime);
	}
	void OnCOllisionEnter(Collision c)
	{
		Debug.Log(c.gameObject.name);
		/*if (Collision.gameObject.name == "Enemy") {
			GameObject.Destroy(gameObject, 3f);
		}*/
	}
}
