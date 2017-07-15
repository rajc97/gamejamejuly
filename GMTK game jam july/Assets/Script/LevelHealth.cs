using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHealth : MonoBehaviour {

    int LevelMaxHealth = 100000; // 100,000 level max heatlh
    int LevelCurrentHealth; //level current health;
    public int Avgmaxhealth; //the percent of health left
    int damage; // how much damage the blocc that was destoryed deals
    Levelreposive flame; // used to get what blocc was destroyed

    int innerlayer = 5; // top layer of level if blocc is destroyed 
    int midlayer = 15; //  middle layer of level if blocc is destroyed
    int outlayer = 30; //  outter layer of level if blocc is destroyed
	// Use this for initialization
	void Start () {
        LevelCurrentHealth = LevelMaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
       
    }
    public void updatehealth(int _damage)
    {
        damage = _damage;

        if (damage == innerlayer)
        {
            LevelCurrentHealth -= damage;
        }

        else if (damage == midlayer)
        {
            LevelCurrentHealth -= damage;
        }

        else if (damage == outlayer)
        {
            LevelCurrentHealth -= damage;
        }
        Avgmaxhealth = LevelCurrentHealth / LevelMaxHealth;
        if (Avgmaxhealth < 50)
        {
            SceneManager.LoadScene("");
        }
    }
    public int GetAvgHealth()
    {
        return Avgmaxhealth = LevelCurrentHealth / LevelMaxHealth;
    }
}
