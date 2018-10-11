using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplodeEnemy : MonoBehaviour {

    private Transform player;
    [SerializeField] int MoveSpeed = 4;
    [SerializeField] int MaxDist = 30;
    [SerializeField] int MinDist = 10;


    private void Start()
    {
        player = GameObject.Find("FPSController").transform;
    }

    void Update()
    {
        

        if (Vector3.Distance(transform.position, player.position) >= MinDist && Vector3.Distance(transform.position, player.position) <= MaxDist)
        {
            
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        }

        if (Vector3.Distance(transform.position, player.position) <= MinDist)
        {
            Player.llaves = 0;
            Destroy(player.gameObject);
            SceneManager.LoadScene(0);
        }
    }
}

