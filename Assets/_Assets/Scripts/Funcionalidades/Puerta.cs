using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour {
    [SerializeField] int necesaryKeys = 3;
    [SerializeField] private int speed = 3;
    bool tieneLlaves = false;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (tieneLlaves == true)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        if (transform.position.y <-10f)
        {
            Destroy(this.gameObject);
        }
    }
    //Comprueba las llaves que tiene el jugador para abrir la puerta si las tiene todas.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Comprobar Llaves");
            if (Player.llaves == necesaryKeys)
            {
                tieneLlaves = true;
                Player.llaves = 0;
 
        }
    }

        


    }
}
