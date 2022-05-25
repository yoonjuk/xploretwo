using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public HealthbarController healthbar;

    //void OnCollisionEnter(Collision collision)
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Rock")
        {
            if (healthbar)
            {
                healthbar.onTakeDamage(10);
            }
        }
    }
}