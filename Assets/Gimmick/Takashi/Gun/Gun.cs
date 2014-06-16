using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	public GameObject bullet;
	public Vector3 ofs = Vector3.zero;
	public float Reload = 0.1f;
	public AudioClip audioClip;

	private AudioSource audioSource;
	private float RepeatTime = 0; 
	private GameObject player;
	private Vector3 direction;

	void Start(){
		player = GameObject.FindWithTag("Player");
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
	}
	// Update is called once per frame
	void Update () {
		direction = player.transform.forward;
		ofs = direction;
		if(Input.GetButton("Fire1"))
		{
			RepeatTime += Time.deltaTime;
			if(RepeatTime >= Reload)
			{
				RepeatTime = 0;
				GameObject obj = Instantiate (bullet, transform.position+ofs, transform.rotation) as GameObject;
				audioSource.PlayOneShot(audioClip);
				Destroy (obj,3f);
			}
		}
	}
}
