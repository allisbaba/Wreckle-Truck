using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position) - transform.position;
       // transform.rotation = Quaternion.LookRotation(player.GetComponent<Rigidbody>().velocity);
       if (GetComponent<Rigidbody>().velocity != Vector3.zero)
       {
           Vector3 lookPoint =
               new Vector3(GetComponent<Rigidbody>().velocity.x, 0, GetComponent<Rigidbody>().velocity.z);
           transform.rotation = Quaternion.LookRotation(lookPoint);
           
       } 
       
        //  enemyRb.AddForce(lookRotation.normalized*speed);
        enemyRb.AddForce(lookDirection.normalized*speed);
        if (transform.position.y< -0.1)
        {
            Destroy(gameObject);
        }
    }
}
