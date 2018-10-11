using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    private const int NUM_ARMAS = 3;
    [SerializeField] public static int llaves = 0;
    [SerializeField] int vida = 3;
    [SerializeField] private Text marcadorVida;
    [SerializeField] private Text marcadorLlaves;
    int vidaMaxima = 3;
    [SerializeField] GameObject[] armas = new GameObject[NUM_ARMAS];
    private AudioSource source;
    [SerializeField] AudioClip damage;
    float tiempo;
    [SerializeField] float cadencia;
    [SerializeField] GameObject bomba;
    [SerializeField] GameObject lanzabombas;
    float tempobomba;
    // Use this for initialization
    void Start() {
        source = GetComponent<AudioSource>();

        for (int i = 0; i < NUM_ARMAS; i++) {
            armas[i].SetActive(false);
        }

        armas[0].SetActive(true);

    }

    // Update is called once per frame
    void Update() {
        tiempo = tiempo + Time.deltaTime;

        if (Input.GetKeyDown("1")) {
            armas[0].SetActive(true);
            armas[1].SetActive(false);
        } else if (Input.GetKeyDown("2")) {
            armas[1].SetActive(true);
            armas[0].SetActive(false);
        }
        if (tiempo > cadencia) {
            if (Input.GetMouseButtonDown(1)) {
                armas[2].SetActive(true);
            } else if (Input.GetMouseButtonUp(1)) {
                Invoke("Lanzagranada", 0.02f);
                tiempo = 0;
                armas[2].SetActive(false);
            }
        }

        marcadorLlaves.text = "Llaves:" + llaves;
    }
    //Se suman las llaves
    private void OnTriggerEnter(Collider Key) {
        if (Key.gameObject.tag == "Key") {
            llaves = llaves + 1;
            Debug.Log("Numero Llaves: " + llaves);
        }

        if (Key.gameObject.tag == "Life") {
            vida = vidaMaxima;
            ActualizarVida();
        }

    }

    public void Lanzagranada(){

        Instantiate(bomba, lanzabombas.transform.position, lanzabombas.transform.rotation);

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
        llaves = 0;
        Destroy(this.gameObject);
        
        SceneManager.LoadScene(0);
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "BalaBoss") {
            recibirDanyo(1);
        }
        if(collision.gameObject.tag == "Moneda") {
            SceneManager.LoadScene(0);
        }

    }

    void ActualizarVida()
    {
        marcadorVida.text = "Vida:" + vida;

    }
}
