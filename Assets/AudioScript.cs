using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {
	public AudioClip audioClip;
	AudioSource audioSource;
	
	void Start() {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
		audioSource.Play ();
	}


	// Update is called once per frame
	void Update () {
	}
}
