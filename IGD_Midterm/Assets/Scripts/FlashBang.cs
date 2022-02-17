using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashBang : GrenadeBase
{
    private RoomControl rm;
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        rm = GameObject.FindGameObjectWithTag("Manager").GetComponent<RoomControl>();
    }

    public override void Detonate()
    {
        Destroy(gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
        rm.Distract(transform.position);
       
    }
}
