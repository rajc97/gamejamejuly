using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {

    float vd,hd;
    float timer=10.0f;

    public void Init(float _vd,float _hd)
    {
        vd = _vd;
        hd = _hd;
    }
    // Update is called once per frame
    void Update ()
    {
        transform.Translate(hd, vd, 0);
        timer -= 0.1f;
        
        if(timer<0)
        {
            Destroy(gameObject);
        }
    }

}
