using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Destroy
    public float lifeDuration = //D³ugoœæ lotu twojego pocisku np 2f;
    private float lifeTimer;

    private Rigidbody bulletRB;
    public float bulletVelocity = //Prêdkoœæ lotu twojego pocisku np 5f;

    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();

        //Destroy
        lifeTimer = lifeDuration;
    }

    void Update()
    {
        //Destroy
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        bulletRb.velocity = transform.forward * bulletVelocity * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
