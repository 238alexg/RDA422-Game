﻿using UnityEngine;
using System.Collections;

public class ShootGun : MonoBehaviour
{
    // Rocket Prefab
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        // left mouse clicked?
        if (Input.GetMouseButtonDown(0))
        {
            // spawn rocket
            // - Instantiate means 'throw the prefab into the game world'
            // - (GameObject) cast is required because unity is stupid
            // - transform.position because we want to instantiate it exactly
            //   where the weapon is
            // - transform.parent.rotation because the rocket should face the
            //   same direction that the player faces (which is the weapon's
            //   parent. 
            //   we can't just use the weapon's rotation because the weapon is
            //   always rotated like 45° which would make the bullet fly really
            //   weird
            GameObject g = (GameObject)Instantiate(bulletPrefab,
                transform.position,
                new Quaternion(transform.parent.rotation.x,transform.parent.rotation.y,transform.parent.rotation.z, transform.parent.rotation.w));

            
            // make the rocket fly forward by simply calling the rigidbody's
            // AddForce method
            // (requires the rocket to have a rigidbody attached to it)
            float force = g.GetComponent<Bullet>().speed;
            g.GetComponent<Rigidbody>().AddForce(g.transform.forward * force);
        }
    }
}