using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour {


    [SerializeField] GameObject player;
    KeyCode up    = KeyCode.W;
    KeyCode down  = KeyCode.S;
    KeyCode left  = KeyCode.A;
    KeyCode right = KeyCode.D;

    int Maxhealth = 100;
    int Currenthealth;

    // Use this for initialization
    void Start ()
    {
        Currenthealth = Maxhealth;
	}

 // Update is called once per frame
    void Update ()
    {
		if(Input.GetKeyDown(up))
        {
            player.transform.Translate(0, 1, 0);
        }
        if (Input.GetKeyDown(down))
        {
            player.transform.Translate(0, -1, 0);
        }
        if (Input.GetKeyDown(left))
        {
            player.transform.Translate(-1, 0, 0);
        }
        if (Input.GetKeyDown(right))
        {
            player.transform.Translate(1, 0, 0);
           
        }
    }

    //health system for the game    
  #region Healthsystem

    public int GetHealth()
    {
        return Currenthealth;
    }

    public void SetHealth(int _health)
    {
        if (_health + Currenthealth >= Maxhealth)
        {
            Currenthealth = Maxhealth;
        }
        else
        {
            Currenthealth += _health;
        }
    }
    public void TakeDamage(int damage)
    {
        if (Currenthealth - damage <= 0)
        {
            Currenthealth = 0;
        }
        else
        {
            Currenthealth -= damage;
        }
    }

#endregion

}
