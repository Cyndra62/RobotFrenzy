using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMachinegun : MonoBehaviour {
    [SerializeField] Transform bala;
    float tiempo=0;
    [SerializeField] float cadencia = 0.05f;
    [SerializeField] AudioClip shoot;
    private AudioSource source;
    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        tiempo = tiempo + Time.deltaTime;
        if (tiempo > cadencia) {
            if (Input.GetMouseButton(0)) {
                source.PlayOneShot(shoot, 1);
                ponerBala();
                tiempo = 0;
                
            }
        }
    }

   private void ponerBala()
    {
        Instantiate(bala, transform.position, transform.rotation);
        
    }
}
