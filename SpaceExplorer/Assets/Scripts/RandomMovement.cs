using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour {
    public float minDistance = 1f;
    public float maxDistance = 2f;
    public GameObject MovementScript;
    Movimiento Move;
    public GameObject PuntuacionScript;
    Puntuacion points;

    float speed=0.15f;
    void Start()
    {
        Move = MovementScript.GetComponent<Movimiento>();
        points = PuntuacionScript.GetComponent<Puntuacion>();
    }

    public Transform target;
	
	// Update is called once per frame
	void Update () {
        Quaternion rotation = transform.rotation;
        transform.Rotate(Vector3.forward, Random.Range(0, 360));
        transform.position += Vector3.Lerp(transform.position, transform.up*1f,10f); 
        transform.rotation = rotation;

        if (points.Points >=1)
        {
            speed = 0.15f + points.Points / 80f;// aumento de velocidad
        }
       

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
    }
    void OnTriggerEnter2D(Collider2D coll)

    {
        if (coll.gameObject.tag == "Player")
        {
            Move.Onsandstorm = true;// Indica al script de movimiento que el jugador esta en la tormenta
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Move.Onsandstorm = false;// Indica al script de movimiento que el jugador no esta en la tormenta
        }
    }

    void Awake()
    {
        
    }
}
