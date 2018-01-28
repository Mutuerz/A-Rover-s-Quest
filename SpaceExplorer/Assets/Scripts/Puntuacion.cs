using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class Puntuacion : MonoBehaviour {

    public float TimeLeft=120;
    public Text time;
    public Text Signals;
    bool Healed = false;
    bool Healed2 = false;

    int tiempo;
    string Puntos;
    public short Points=0, heal = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Points == 8)
        {
            SceneManager.LoadScene(5);
        }
        TimeLeft -= Time.deltaTime;
        if (TimeLeft <= 0)
        {
            TimeLeft = 0;
            GameOver();
        }
        if (Input.GetKeyDown("space"))
        {
            TimeLeft -= 5f;
        }
        tiempo = (int)TimeLeft;
        Puntos = (8 - Points).ToString();
        Signals.text = "Signals Left: " + Puntos;
        time.text ="Time Left: " + tiempo.ToString();
        if (Points==8)
        {
            Signals.text = "You WIN!";
        }
        if (heal == 1 && !Healed)
        {
            Healed = true;
            TimeLeft += 20f;
        }
        if (heal == 2 && !Healed2)
        {
            Healed2 = true;
            TimeLeft += 20f;
        }


    }
    void GameOver()
    {
        SceneManager.LoadScene(5);
    }
}
