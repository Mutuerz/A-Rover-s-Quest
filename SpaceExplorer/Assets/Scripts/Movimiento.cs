using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public bool Onsandstorm;// Identifica si el jugador esta en la tormenta
    public float MarkTimer = 2f, Intervalo=1f; // Intervalo de play del sonido
    public bool onObject=false;
    public string meteoro; // entero que identifica al meteorito el cual se encontro

    public GameObject Area;
    AreaControl3 area;
    public Transform Prefab;// x prefabricada para marcar
    GameObject[] Objects;// arreglo de objetos de marcas para eliminarlas
    public AudioSource Pick;
    public Text aviso;// avisos o advertencias
    public Text adevertencia;
    public Animator anim;
    public bool moving = false;
    float speed = 20f, speedRotation = 50f;
    // Use this for initialization
    void Start()
    {

        area = Area.GetComponent<AreaControl3>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Onsandstorm)
        {
            adevertencia.text = "CAREFUL! YOU ARE ON SANDSTORM";
          
        }
        else 
        {
            adevertencia.text = "";
        }
        anim.SetBool("IsMoving 0", moving);


        
        Movement();
        if (Time.time - Intervalo >= MarkTimer && Time.time != 0)
        {
            if (Input.GetKeyDown("space") && !Onsandstorm)
            {
              
                Intervalo = Time.time;
                Instantiate(Prefab, transform.position, Quaternion.identity);  // crea una instancia de un prefab      
            }
        }
       if (onObject)
        {
            if (Input.GetKeyDown("enter"))
            {
                aviso.text = "Signal Found!";
               
                if (!Pick.isPlaying)
                {
                    Pick.Play();
                }
                Destruir();
                MarkTimer = 1f;
                StartCoroutine(ClearUI());// limpia cualqueir aviso en ui

            }
        }
       
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Object")
        {
            onObject = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag=="object")
            {
            onObject = false;
        }
        
    }

    //Subrutinas
    void Movement()
    {
        if (Input.GetKey("up") || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            moving = true;
        }

        if (Input.GetKey("left") || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * speedRotation * Time.deltaTime);
            moving = true;
        }

        if (Input.GetKey("down") || Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            moving = true;
        }

        if (Input.GetKey("right") || Input.GetKey(KeyCode.D ))
        {
            transform.Rotate(Vector3.back * speedRotation * Time.deltaTime);
            moving = true;
        }


        if (Input.GetKey(KeyCode.D) != true && Input.GetKey(KeyCode.A) != true && Input.GetKey(KeyCode.S) != true && Input.GetKey(KeyCode.W) != true)
        {
            moving = false;
        }


    }

    void Discover()
    {
    }
    void Destruir()
    {
        GameObject[] marks = GameObject.FindGameObjectsWithTag("Mark");
        foreach (GameObject enemy in marks)
        {
            GameObject.Destroy(enemy);
        }      
            
    }

    IEnumerator ClearUI ()
    {
        yield return new WaitForSeconds(3f);
        aviso.text = "";
    }
}
    

