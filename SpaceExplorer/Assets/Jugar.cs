using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Jugar : MonoBehaviour {
	public void Option1 (){
		SceneManager.LoadScene("Story");
	}
	public void Option2 (){
		SceneManager.LoadScene("Instructions");
	}
	public void Option3 (){
		
		SceneManager.LoadScene("Menu");
	}
	public void Option4 (){
		
		SceneManager.LoadScene("Story2");
       
	}
    public void Option5 ()
    {
        SceneManager.LoadScene(1);
    }
	public void quitGame(){
		Application.Quit();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
