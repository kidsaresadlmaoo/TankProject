using UnityEngine;
using System;

public class projectile : MonoBehaviour
{

    [SerializeField] private float bulletForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        GetComponent<Rigidbody>().linearVelocity = transform.forward * bulletForce;
        Destroy(gameObject, 2);
        Debug.Log("fire");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
