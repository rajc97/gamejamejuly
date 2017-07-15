using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LGG_TurretBulletScript : MonoBehaviour
{
    public Animator myBulletAnimator;
    public float speed = 10.0f;
    private float distanceToPlayer;
    public GameObject target;
    private float bulletTimer = 2.0f;
    public GameObject explosionParticles;
    private bool exploding = false;
    // Use this for initialization

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        explosionParticles.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
       
        Vector3 distance = transform.position - target.transform.position;
        distanceToPlayer = distance.magnitude;
        if (distanceToPlayer >= 1.0f && exploding == false)
        {

            float bulletSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, bulletSpeed);

        }
        else if (distanceToPlayer < 4.0f || exploding == true)
        {
         
            bulletTimer -= Time.deltaTime;
            myBulletAnimator.SetBool("PlayerClose", true);
            exploding = true;
            explosionParticles.SetActive(true);
        }
        if(bulletTimer <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        bulletTimer -= Time.deltaTime;
        myBulletAnimator.SetBool("PlayerClose", true);
    }
}
