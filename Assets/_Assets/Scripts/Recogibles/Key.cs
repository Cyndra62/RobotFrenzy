using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Key : MonoBehaviour {
    [SerializeField] private bool entertrigger =true;
    [SerializeField] private float RotationSpeed;
    [SerializeField] private float velocidad;
    [SerializeField] GameObject Spawn;
    [SerializeField] float contador = 0;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        contador = contador + Time.deltaTime;
        
        transform.Rotate( 0,1,0 + RotationSpeed *Time.deltaTime) ;

        if (contador >= 0 && contador <= 0.5 ) {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
        }
        if(contador >=0.5 && contador <= 1) {
           transform.Translate(Vector3.down * velocidad * Time.deltaTime); 
        }
        if (contador > 1) {
            contador = 0;
        }
        

    }

    private void OnTriggerEnter(Collider player)
    {
        
        if (player.gameObject.tag == "Player")
        {
            Debug.Log("Destruye Llave");
            Destroy(Spawn);
            Destroy(this.gameObject);
            
        }
              
    }
}
