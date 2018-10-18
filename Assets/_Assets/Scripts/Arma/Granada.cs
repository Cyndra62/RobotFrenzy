using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour {
    private Rigidbody rb;
    [SerializeField] float fuerza;
    [SerializeField] GameObject explosion;
    [SerializeField] GameObject damages;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * fuerza);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision) {
        Instantiate(explosion, transform.position, transform.rotation);
        Instantiate(damages, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
