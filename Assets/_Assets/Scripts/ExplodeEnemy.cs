using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeEnemy : MonoBehaviour
{

    private Transform player;
    int MoveSpeed = 4;
    [SerializeField] int MaxDist = 10;
    [SerializeField] int MinDist = 1;

    private void Start()
    {
        player = GameObject.Find("FPSController").transform;
    }

    void Update()
    {
        transform.LookAt(player);

        if (Vector3.Distance(transform.position, player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, player.position) <= MaxDist)
            {
                transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            }

        }

        if (Vector3.Distance(transform.position, player.position) <= MinDist)
        {
            Destroy(player.gameObject);
        }
    }
}

