using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuchillo : MonoBehaviour {
    private Rigidbody rb;
    private CapsuleCollider cl;
    [SerializeField] float fuerza;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        cl = GetComponent<CapsuleCollider>();
        
        rb.AddForce(transform.forward * fuerza);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    private void OnCollisionEnter(Collision collision) {
        rb.isKinematic=true;

        if(collision.gameObject.tag=="Enemigo") {
            Destroy(this.gameObject);
        }
        cl.enabled = true;
        Debug.Log("Activa Trigger");
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            Player.num_cuchillos++;
            Destroy(this.gameObject);
        }
    }


}

