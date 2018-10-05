using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] public static int llaves = 0;
    int vida;
    int vidaMaxima;
    //Arma[] armas;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //Se suman las llaves
    private void OnTriggerExit(Collider Key)
    {
        if(Key.gameObject.tag == "Key")
        {
            llaves=llaves+1;
            Debug.Log("Numero Llaves: " + llaves);
        }
        
        
    }

    public void CambiarArma() {

    }

    public int getLlaves()
    {
        return llaves;
    }

    public void recibirDanyo(int danyo) {

        vida = vida - danyo;
        if (vida <= 0) {
            vida = 0;
            Morir();
        }
    }
    public void Morir() {
        Destroy(this.gameObject);
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "BalaBoss") {
            recibirDanyo(1);
        }

    }
}
