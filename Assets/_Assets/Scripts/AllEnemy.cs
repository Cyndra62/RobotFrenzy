﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemy : MonoBehaviour
{
    bool EstoyVivo = true;
    bool VeoJugador = false;
    bool EstoyRecargando = false;
    int vida = 3;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bala")
        {
            vida--;
        }
     if (vida <= 0)
        {
            Destroy(this.gameObject);
        }
     
    }
}

  
