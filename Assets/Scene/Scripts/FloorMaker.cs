using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FloorMaker : MonoBehaviour {
	public List<GameObject> blocks = new List<GameObject>();
	public GameObject destroyer;
	public Vector3 firstPos = Vector3.zero;
	public int numBlocks = 300;

	void Awake()
	{
		for(int i=0;i<numBlocks;++i)
		{
/*
			if(i%10==0&&i/10!=3)
				Instantiate(blocks[0],firstPos+Vector3.right*i+Vector3.up,transform.rotation);
			if(i%10==1&&i/10!=3)
			{
				Instantiate(blocks[0],firstPos+Vector3.right*i+Vector3.up*1,transform.rotation);
				Instantiate(blocks[1],firstPos+Vector3.right*i+Vector3.up*2,transform.rotation);
			}
*/
			if(i/10==3)
				Instantiate(blocks[2],firstPos+Vector3.right*i+Vector3.up*0.5f,transform.rotation);
			Instantiate(blocks[2],firstPos+Vector3.right*i,transform.rotation);
			Instantiate(blocks[2],firstPos+Vector3.right*i+Vector3.up*-1,transform.rotation);
			Instantiate(blocks[2],firstPos+Vector3.right*i+Vector3.up*-2,transform.rotation);
			Instantiate(destroyer,firstPos+Vector3.right*i+Vector3.up*-4,transform.rotation);

		}

	}
}
