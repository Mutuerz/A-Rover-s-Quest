using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaControl3 : MonoBehaviour
{
    
    public GameObject MovementScript;
    public GameObject PuntuacionScript;
    public bool thisobject = false, thiscollectable = false;
    Movimiento Move;
    Puntuacion points;
    Puntuacion heal;

    void Start()
    {
        Move = MovementScript.GetComponent<Movimiento>();
        points = PuntuacionScript.GetComponent<Puntuacion>();
        heal = PuntuacionScript.GetComponent<Puntuacion>();


    }

    void Update()
    {
        if (Move.onObject && thisobject && Input.GetKeyDown("enter"))
        {
            Destroy(gameObject);
            points.Points +=1;
        }
        if (thiscollectable && Input.GetKeyDown("enter"))
        {

            Destroy(gameObject);
            heal.heal += 1;
        }

    }

    void OnTriggerEnter2D(Collider2D coll)

    {
        if (coll.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Object")
            {
                Move.onObject = true;// cambiamos el intervalo de sonido del beep
                thisobject = true;

            }
            if (gameObject.tag=="Collectable")

            {
                Move.onObject = true;
                thiscollectable = true;
            }
        }
        
        
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Object")
            {
                Move.onObject = false;// cambiamos el intervalo de sonido del beep
                thisobject = false;

            }
            if (gameObject.tag == "Collectable")

            {
                Move.onObject = false;
                thiscollectable = false;
            }
        }
    }
}