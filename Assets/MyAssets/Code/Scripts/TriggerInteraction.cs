using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{
    [SerializeField] int damage = 10;
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<IDamage>() != null)
        {
            collider.GetComponent<IDamage>().DoDamage(damage);
        }
    }

    /*
     void OnTriggerExit(Collider collider) {
        if (collider.CompareTag("Player")) {
            print("Player left");
        }
    } 
    */

    /*
    void OnTriggerStay(Collider collider) {
        if (collider.CompareTag("Player")) {
            print("Player stayed");
        }
    }
    */
}
