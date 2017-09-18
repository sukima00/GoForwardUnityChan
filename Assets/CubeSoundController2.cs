using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSoundController2 : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip block;

    // Use this for initialization
    void Start () {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = block;       // 鳴らす音(変数)を格納.
        audioSource.loop = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "groundTag")
        {
            audioSource.Play();
        }
    }
}
