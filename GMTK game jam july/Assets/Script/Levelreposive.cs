using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelreposive : MonoBehaviour {
    int damage;
    public LevelHealth levheal; // level's health

    string innerlayer = "InnerLayer";
    string midlayer = "MiddleLayer";
    string outterlayer = "Outterlayer";

    int damageinnerlayer = 5; // top layer of level if blocc is destroyed 
    int damagemidlayer = 15; //  middle layer of level if blocc is destroyed
    int damageoutlayer = 30; //  outter layer of level if blocc is destroyed

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlayerBullet")
        {
           if(tag == innerlayer)
            {
                damage = damageinnerlayer;
                levheal.updatehealth(damage);
            }

           else if (tag == midlayer)
            {
                damage = damagemidlayer;
                levheal.updatehealth(damage);
            }

            else if (tag == outterlayer)
            {
                damage = damageoutlayer;
                levheal.updatehealth(damage);
            }

        }
        
    }
}
