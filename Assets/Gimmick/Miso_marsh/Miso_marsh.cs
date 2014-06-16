using UnityEngine;
using System.Collections;

public class Miso_marsh : MonoBehaviour {
	
	public GameObject Unitychan;
	public AudioClip audioclip;
	private AudioSource audiosorse;
	private UnityChanMove us;
	private float down = 2.0f;


	// Use this for initialization
	void Start () {
		audiosorse = gameObject.GetComponent<AudioSource> ();
		audiosorse.clip = audioclip;

		Unitychan = GameObject.FindWithTag ("Player");
		us = Unitychan.GetComponent<UnityChanMove> ();
	}

	void OnTriggerEnter(Collider c){
		if(c.tag == "Player")
		{
			audiosorse.PlayOneShot (audioclip);
			us.speed /= down;
		}
	}

	void OnTriggerExit(Collider c){
		if(c.tag == "Player")
			us.speed *= down;
	}

}
