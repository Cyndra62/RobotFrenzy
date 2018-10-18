using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemy : MonoBehaviour
{
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
    [SerializeField] int speed;
    [SerializeField] TextMesh tm;

    // Use this for initialization
    void Start()
    {
        tm.text = "" + vida;
        player = GameObject.Find("FPSController").transform;
        InvokeRepeating("RotarAleatoriamente", 1, 3);
    }

    // Update is called once per frame
    void Update() {
        
        if (Vector3.Distance(transform.position, player.position) >= MinDist && Vector3.Distance(transform.position, player.position) <= MaxDist) {
            transform.LookAt(player);

        } else { transform.Translate(Vector3.forward * speed * Time.deltaTime); }
    }

    public int DetectarDistanciaAlPersonaje() {

        return 0 ;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bala") 
            {
            recibirDanyo(1);
            }

        if (collision.gameObject.tag =="Franco") 
            {
            recibirDanyo(3);
            }

        if (collision.gameObject.tag != "Franco" && collision.gameObject.tag != "Bala") 
            {
            RotarAleatoriamente();
            }
        
    }
    private void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "Bomb") {
            recibirDanyo(5);
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

    private void RotarAleatoriamente()
    {
        float rotacion = Random.Range(0f, 360f);
        transform.eulerAngles = new Vector3(0, rotacion, 0);
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

  