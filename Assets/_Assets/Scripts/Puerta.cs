using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour {
    [SerializeField] int necesaryKeys = 3;
    
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    //Comprueba las llaves que tiene el jugador para abrir la puerta si las tiene todas.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Comprobar Llaves");
        other.gameObject.tag = ("Player");
        if ( Player.llaves == necesaryKeys)
        {
            Player.llaves = 0;
            Destroy(this.gameObject);
        }
    }
}
