using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapons : MonoBehaviour {
    [SerializeField] Transform bala;
    [SerializeField] int cadencia =2;
    float tiempo = 0;
    [SerializeField] int MaxDist = 30;
    [SerializeField] int MinDist = 10;
    // Use this for initialization
    private Transform player;

    void Start() {
        
        player = GameObject.Find("FPSController").transform;
}

    // Update is called once per frame
    void Update() {
        tiempo = tiempo + Time.deltaTime;
        if (tiempo > cadencia) {

            if (Vector3.Distance(transform.position, player.position) >= MinDist && Vector3.Distance(transform.position, player.position) <= MaxDist) {
                transform.LookAt(player);
                ponerBala();
                tiempo = 0;
            }
        }
    }

    void ponerBala() {
        Instantiate(bala, transform.position, transform.rotation);
    }
}
