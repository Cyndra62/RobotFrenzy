using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private const int NUM_ARMAS = 2;
    [SerializeField] public static int llaves = 0;
    [SerializeField] int vida=3;
    int vidaMaxima;
    [SerializeField]GameObject[] armas = new GameObject [NUM_ARMAS];
    
	// Use this for initialization
	void Start () {
       
        for(int i =0; i < NUM_ARMAS; i++) {
            armas[i].SetActive(false);
        }

        armas[0].SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("1")) {
            armas[0].SetActive(true);
            armas[1].SetActive(false);
        }else if (Input.GetKeyDown("2")) {
            armas[1].SetActive(true);
            armas[0].SetActive(false);
        }
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
