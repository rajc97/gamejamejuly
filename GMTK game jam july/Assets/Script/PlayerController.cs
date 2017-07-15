using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour {

    [SerializeField] GameObject player;
    KeyCode up    = KeyCode.W;
    KeyCode down  = KeyCode.S;
    KeyCode left  = KeyCode.A;
    KeyCode right = KeyCode.D;

    // Use this for initialization
    void Start ()
    {
		
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
}
