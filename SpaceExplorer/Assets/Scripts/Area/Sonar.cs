using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonar : MonoBehaviour {
    public AudioSource beep;
    Transform child;


    public bool Objeto1=false, Objeto2 = false, Objeto3 = false, Objeto4 = false;
    bool unavez=false;
    // Use this for initialization
    void Start () {
        
    }
    private void Awake()
    {
        StartCoroutine(DeleteCircle(5f));
    }

    // Update is called once per frame
    void Update () {
        if (unavez)
        {
            Objeto1 = true;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Object")
        {
            beep.Play();
        }

    }

    IEnumerator DeleteCircle (float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
