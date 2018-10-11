using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbot : MonoBehaviour {
    bool EstoyVivo = true;
    [SerializeField] int vida = 3;
    //int MoveSpeed;
    int distanciaDeteccion;
    //int distanciaExplosion;
    int danyo;
    int vidaMaxima;
    private Transform player;
    [SerializeField] int MaxDist = 30;
    [SerializeField] int MinDist = 10;
    [SerializeField] Transform muertePartic;
    [SerializeField] GameObject premio;
    
    [SerializeField] TextMesh tm;

    [SerializeField] GameObject Spawn0;
    [SerializeField] GameObject Spawn1;
    [SerializeField] GameObject Spawn2;
    [SerializeField] GameObject Spawn3;


    // Use this for initialization
    void Start() {
        tm.text = "" + vida;
        player = GameObject.Find("FPSController").transform;
        
    }

    // Update is called once per frame
    void Update() {

        
    }

    public int DetectarDistanciaAlPersonaje() {

        return 0;
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Bala") {
            recibirDanyo(1);
        }
        if (collision.gameObject.tag == "Franco") {
            recibirDanyo(3);

        }

    }


    public void Morir() {
        EstoyVivo = false;
        //Particulas
        Instantiate(muertePartic, transform.position, transform.rotation);
        //Gritos de agonia
        Destroy(Spawn0);
        Destroy(Spawn1);
        Destroy(Spawn2);
        Destroy(Spawn3);
        Instantiate(premio, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        //¿Recompensa?


    }

    public void recibirDanyo(int danyo) {

        vida = vida - danyo;
        tm.text = "" + vida;
        if (vida <= 0) {
            vida = 0;
            Morir();
        }
    }

    public void IncrementarVida(int incrementoVida) {
        vida = vida + incrementoVida;
        if (vida > vidaMaxima) vida = vidaMaxima;
    }
}
