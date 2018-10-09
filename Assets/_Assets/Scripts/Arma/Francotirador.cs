using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Francotirador : MonoBehaviour {
    [SerializeField] Transform bala;
    [SerializeField] float tiempo=4;
    private AudioSource source;
    [SerializeField] AudioClip shoot;
    [SerializeField] AudioClip reload;
    [SerializeField] float cadencia = 3.5f;
    [SerializeField] GameObject camara;
    // Use this for initialization
    void Start() {
        source = GetComponent<AudioSource>();
        camara.SetActive(false);
        tiempo = 4;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = tiempo + Time.deltaTime;
        if(tiempo > cadencia) { 

             if (Input.GetMouseButtonDown(0))
             {
                 source.PlayOneShot(shoot, 1);
                 ponerBala();
                 source.PlayOneShot(reload, 1);
                 tiempo = 0;
                 
            
          }
        }
        if (Input.GetMouseButton(1))
          {
             camara.SetActive(true);
          } else
          {
             camara.SetActive(false);
          }
    }

    private void ponerBala() {
        Instantiate(bala, transform.position, transform.rotation);
        
    }
}

