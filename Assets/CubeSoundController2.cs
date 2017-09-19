using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSoundController2 : MonoBehaviour {
    
    

    // Use this for initialization
    void Start () {
        
        
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "CubeTag" || coll.gameObject.tag == "groundTag")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
