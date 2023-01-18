using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject ball;
    public Transform pointOfShoot;

    private void Shoot()
    {
        Debug.Log("Shoot");

    }

    private void Start()
    {
        Shoot();
        Instantiate (ball, pointOfShoot.transform.position, Quaternion.identity);
        


    }


    private void Update()
    {
        
    }

  



}
