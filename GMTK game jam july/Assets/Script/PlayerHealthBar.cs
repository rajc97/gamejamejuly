using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBar : MonoBehaviour {

    [SerializeField] PlayerScript player;

	// Update is called once per frame
	void Update ()
    {
        float health = player.GetHealth();
        Vector3 scale = GetComponent<RectTransform>().localScale;
        scale.y = health / 100.0f;
        GetComponent<RectTransform>().localScale=scale;
	}
}
