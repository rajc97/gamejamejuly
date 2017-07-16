using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHealth : MonoBehaviour {

   public float LevelMaxHealth = 100000; // 100,000 level max heatlh
  public  float LevelCurrentHealth; //level current health;
    public float Avgmaxhealth; //the percent of health left
    int damage; // how much damage the blocc that was destoryed deals
   

    int innerlayer = 25000; // top layer of level if blocc is destroyed 
    int midlayer = 15; //  middle layer of level if blocc is destroyed
    int outlayer = 30; //  outter layer of level if blocc is destroyed
	// Use this for initialization
	void Start () {
        LevelCurrentHealth = LevelMaxHealth;
        Avgmaxhealth = 100;

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
          
        Avgmaxhealth =(LevelCurrentHealth / LevelMaxHealth) *100; 
        if (Avgmaxhealth <= 0)
        {
            SceneManager.LoadScene("");
        }
    }
    public float GetAvgHealth()
    {
        return Avgmaxhealth = LevelCurrentHealth / LevelMaxHealth;
    }
}
