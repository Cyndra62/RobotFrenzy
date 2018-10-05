using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemy : MonoBehaviour
{
    bool EstoyVivo = true;
    int vida = 3;
    //int MoveSpeed;
    int distanciaDeteccion;
    //int distanciaExplosion;
    int danyo;
    int vidaMaxima;
    private Transform player;
    [SerializeField] int MaxDist = 30;
    [SerializeField] int MinDist = 10;
    [SerializeField] Transform muertePartic;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("FPSController").transform;
    }

    // Update is called once per frame
    void Update() {
        if (Vector3.Distance(transform.position, player.position) >= MinDist && Vector3.Distance(transform.position, player.position) <= MaxDist) {
            transform.LookAt(player);
            
        }
    }

    public int DetectarDistanciaAlPersonaje() {

        return 0 ;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bala") {
            recibirDanyo(1);
        }
        
    }
    public void Morir() {
        EstoyVivo = false;
        //Particulas
        Instantiate(muertePartic, transform.position, transform.rotation);
        //Gritos de agonia
        Destroy(this.gameObject);
        //¿Recompensa?

        
    }

    public void recibirDanyo(int danyo) {

        vida = vida - danyo;
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

  