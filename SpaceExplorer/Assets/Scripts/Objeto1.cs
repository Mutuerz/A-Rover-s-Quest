using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto1 : MonoBehaviour {
    public SpriteRenderer sr;

     Sonar sonar;
    // Use this for initialization
    void Start () {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
       
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag=="Mark" )
        {
            sr.enabled = true;
        }
      
    }
}
