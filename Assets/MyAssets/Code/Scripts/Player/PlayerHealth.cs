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

        // adding the "?" avoids the game from crashing in case the GameManager would not exist
        GameManager.instance?.PrintMessage("received damage: " + damage);
        GameManager.instance?.PrintMessage("current HP: " + hitPoints);

        GameManager.instance?.AddScore(-10);
    }

    private void Kill()
    {
        // Destroy(gameObject);
        GetComponent<InitCheckPoint>().SnapToCheckPoint();
    }
}
