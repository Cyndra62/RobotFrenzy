using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    [SerializeField] Transform enemigo;

    [SerializeField] private float tiempo;
    [SerializeField] private float ratio;
    
    // Use this for initialization
    void Start()
    {
        


    }
    // Update is called once per frame
    void Update()
    {
        tiempo = tiempo + Time.deltaTime;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (tiempo > ratio)
            {
                Instantiate(enemigo, transform.position, Quaternion.identity);
                tiempo = 0;
            }
            
        }

        if (other.gameObject.tag == "Llave")
        {

        } else if(other.gameObject.tag == "Enemigo") {


            
          }

    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") 
            {
            tiempo = 0;

            }
    }

}
