using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Tomenu());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Tomenu ()
    {
        yield return new WaitForSeconds(3F);
        SceneManager.LoadScene(0);
    }

}
