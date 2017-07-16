using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelreposive : MonoBehaviour {
    int damage;
    public LevelHealth levheal; // level's health

    string innerlayer = "InnerLayer";
    string midlayer = "MiddleLayer";
    string outterlayer = "Outterlayer";

    int damageinnerlayer = 25000; // top layer of level if blocc is destroyed 
    int damagemidlayer = 15; //  middle layer of level if blocc is destroyed
    int damageoutlayer = 30; //  outter layer of level if blocc is destroyed

   



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerBullet")
        {
            if (tag == innerlayer)
            {
                damage = damageinnerlayer;
                levheal.updatehealth(damage);
                Destroy(gameObject);
            }

            else if (tag == midlayer)
            {
                damage = damagemidlayer;
                levheal.updatehealth(damage);
                Destroy(gameObject);
            }

            else if (tag == outterlayer)
            {
                damage = damageoutlayer;
                levheal.updatehealth(damage);
                Destroy(gameObject);
            }

        }

    }
}
