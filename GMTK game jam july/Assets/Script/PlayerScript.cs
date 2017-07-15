using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{

    #region SerializeField
    [Header("Player")]
    [SerializeField] GameObject player;
    [SerializeField] Animation player_anim;
    [SerializeField] int Maxhealth = 100;
    [SerializeField] int Currenthealth;
    public float vertical_direction = 0f;
    public float horizontal_direction = 0f;
    public float speed = 0.01f;

    [Header("Sound")]
    [SerializeField] AudioClip Shoot_sound;
    [SerializeField] AudioClip Take_dmg_sound;

    [Header("Projectile")]
    [SerializeField] GameObject bullet;

    #endregion

    #region KeyBlinding
    KeyCode up = KeyCode.W;
    KeyCode down = KeyCode.S;
    KeyCode left = KeyCode.A;
    KeyCode right = KeyCode.D;
    KeyCode Fire = KeyCode.K;
    KeyCode takedmg = KeyCode.M;
    KeyCode heal = KeyCode.L;
#endregion



    float vertical_movement = 0;
    float horizontal_movement = 0;
    
    

    // Use this for initialization
    void Start()
    {
        Currenthealth = Maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        // input
        Movement_control();
        //render
        player.transform.Translate(-horizontal_movement, -vertical_movement, 0);
        //Instantiate(bullet);
    }

    void Movement_control()
    {

        if (Input.GetKeyDown(up))
        {
            vertical_direction = speed;
        }
        if (Input.GetKeyDown(down))
        {
            vertical_direction = -speed;
        }
        if (Input.GetKeyDown(left))
        {
            horizontal_direction = -speed;
        }
        if (Input.GetKeyDown(right))
        {
            horizontal_direction = speed;
        }
        if(Input.GetKeyUp(up)||Input.GetKeyUp(down))
        {
            vertical_direction = 0;
        }
        if (Input.GetKeyUp(left) || Input.GetKeyUp(right))
        {
            horizontal_direction = 0;
        }
        if (Input.GetKeyDown(Fire))
        {
            if(!(vertical_direction==0&&horizontal_direction==0))
            {
                horizontal_movement = horizontal_direction;
                vertical_movement = vertical_direction;
            }
            Shoot(bullet);
        }

        if(Input.GetKeyDown(takedmg))
        {
            Currenthealth -= 10;
        }
        if(Input.GetKeyDown(heal))
        {
            Currenthealth += 5;
        }
    }

    #region Health System Code

    public int GetHealth()
    {
        return Currenthealth;
    }

    public void SetHealth(int _health)
    {
        if (_health + Currenthealth >= Maxhealth)
            Currenthealth = Maxhealth;
        else
            Currenthealth += _health;
    }

    public void TakeDamage(int damage)
    {
        if (Currenthealth - damage <= 0)
            Currenthealth = 0;
        else
            Currenthealth -= damage;
    }

    #endregion
    public void Shoot(GameObject _projectile)
    {
        GameObject shot=(GameObject)Instantiate(_projectile, transform.position, transform.rotation);
        shot.GetComponent<ProjectileController>().Init(vertical_movement, horizontal_movement);
        
    }
}
