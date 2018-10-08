using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {
    [SerializeField] int MoveSpeed;
    Collision colision;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "BalaBoss") {

        } else {
            Destroy(this.gameObject);
        }
        
    }
    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.tag == "BalaBoss") {

        } else {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject.tag == "BalaBoss") {

        } else {
            Destroy(this.gameObject);
        }
    }
}
