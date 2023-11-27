using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCheckPoint : MonoBehaviour
{
    [HideInInspector] public int setCheckPoint = 0;

    void OnTriggerEnter(Collider collider)
    {
        // using CompareTag method rather than comparing collider.tag with the expected string, 
        // is much faster in execution time!!
        if (!collider.gameObject.CompareTag("Player")) return;

        GameManager.instance.RegisterCheckPoint(setCheckPoint);
        GameManager.instance.PrintMessage("set check point to " + setCheckPoint);
    }
}
