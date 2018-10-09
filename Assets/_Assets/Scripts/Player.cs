using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    private const int NUM_ARMAS = 2;
    [SerializeField] public static int llaves = 0;
    [SerializeField] int vida=3;
    [SerializeField] private Text marcadorVida;
    [SerializeField] private Text marcadorLlaves;
    int vidaMaxima = 3;
    [SerializeField]GameObject[] armas = new GameObject [NUM_ARMAS];
    private AudioSource source;
    [SerializeField] AudioClip damage;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();

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
        marcadorLlaves.text = "Llaves:" + llaves;
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
        source.PlayOneShot(damage, 1);
        vida = vida - danyo;
        ActualizarVida();
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

    void ActualizarVida()
    {
        marcadorVida.text = "Vida:" + vida;

    }
}
