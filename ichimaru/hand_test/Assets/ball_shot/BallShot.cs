using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BallShot : MonoBehaviour{
    public GameObject ballPrefab;
    public float speed;
 
    void Update ()
    {
        if(Input.GetKeyDown("space"))
        {
            GameObject ball =  (GameObject)Instantiate(ballPrefab, transform.position, Quaternion.identity);
            Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
            ballRigidbody.AddForce(transform.forward * speed);
        }
    }
}