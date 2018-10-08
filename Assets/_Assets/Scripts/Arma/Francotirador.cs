using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Francotirador : MonoBehaviour {
    [SerializeField] Transform bala;
    [SerializeField] int tiempo;
    private AudioSource source;
    [SerializeField] AudioClip shoot;
    // Use this for initialization
    void Start() {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButtonDown(0)) {
            source.PlayOneShot(shoot, 1);
            ponerBala();
            
        }
    }

    private void ponerBala() {
        Instantiate(bala, transform.position, transform.rotation);
        
    }
}

