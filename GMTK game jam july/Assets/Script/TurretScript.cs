using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public Animator turretAnim;
    public GameObject target;
    public GameObject bullet;
    public LayerMask canSeeMask;
    public Transform laserOrigin;
    
    private float maxDelay = 3.0f;
    private float shotTime = 3.0f;

    // Use this for initialization

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.transform.position.x, target.transform.position.y + 1.1f, target.transform.position.z);
        transform.LookAt(newPos);
        Debug.DrawRay(laserOrigin.transform.position, laserOrigin.transform.up, Color.green);
        RaycastHit hit;
      RaycastHit hit2; 
        if (Physics.Raycast(laserOrigin.position, transform.forward, out hit, 400, canSeeMask) && (hit.collider.tag == "Player"))
        {
            Shoot();
        }
      
       else if (Physics.Raycast(laserOrigin.position, transform.forward, out hit2, 400, canSeeMask))
        {
            if (hit2.collider.tag != "Player")
            {
                turretAnim.SetBool("PlayerSpotted", false);
                shotTime = maxDelay;
            }
        }







    }
    void Shoot()
    {
        if (shotTime <= 0)
        {


            Instantiate(bullet, new Vector3(laserOrigin.position.x, laserOrigin.position.y, laserOrigin.position.z), Quaternion.Euler(transform.rotation.z, transform.rotation.x, transform.rotation.y));

            shotTime = maxDelay;
        }
        else
        {
            turretAnim.SetBool("PlayerSpotted", true);
            shotTime -= Time.deltaTime;

        }
    }


}
