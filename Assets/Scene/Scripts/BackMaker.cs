using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackMaker : MonoBehaviour {
	public Sprite s;
	public List<GameObject> backs = new List<GameObject>();
	public int numBacks = 100;
	public Vector3 firstPos = new Vector3(0,0,0);
	// Use this for initialization
	void Start () {
		for(int i=0;i<100;++i)
		{
			Instantiate(backs[Random.Range(0,backs.Count)],firstPos+Vector3.right*i*32,transform.rotation);
		}
	}
}
