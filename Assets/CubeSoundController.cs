using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSoundController : MonoBehaviour {
    private AudioSource audioSource;
    public AudioClip sound;

	// Use this for initialization
	void Start () {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = sound;
        audioSource.loop = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        audioSource.Play();
    }
}
