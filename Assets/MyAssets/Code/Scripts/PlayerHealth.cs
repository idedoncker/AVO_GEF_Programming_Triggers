using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamage
{
    [SerializeField] int initHP = 10;

    public int hitPoints
    {
        get { return initHP; }
        set { initHP = value; }
    }

    public void DoDamage(int damage)
    {
        hitPoints -= damage;

        if (hitPoints <= 0)
        {
            Kill();
        }

        print("received damage: " + damage);
        print("current HP: " + hitPoints);
    }

    private void Kill()
    {
        Destroy(gameObject);
    }
}
