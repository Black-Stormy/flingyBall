﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootyshoot : MonoBehaviour
{

    public GameObject splosion;
    private GameObject my_splosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void endAnimation()
    {
        
    }

    void fireProjectile()
    {

        // apply recoil to parent transform
        Rigidbody parentRb = transform.parent.GetComponent<Rigidbody>();
        floatyShip parentShip = transform.parent.GetComponent<floatyShip>();
        parentShip.Notify("projectile fired", gameObject);
        float tempmass = parentRb.mass;
        parentRb.mass = 18f;
        parentRb.AddForce(transform.localRotation.eulerAngles, ForceMode.Impulse);
        parentRb.mass = tempmass;
        // make a splosion
        my_splosion = Instantiate(splosion, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
