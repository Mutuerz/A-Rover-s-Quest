using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeepInterval : MonoBehaviour {
    public AudioSource Beep; // Sonido Beep Detector objetos
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Beep.Play();
	}
}
