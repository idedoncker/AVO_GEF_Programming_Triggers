using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHealth : MonoBehaviour, IDamage
{
    [SerializeField] GameObject destroyedWall;

    public int hitPoints { get; set; }

    public void DoDamage(int damage)
    {
        destroyedWall.SetActive(true);
        destroyedWall.transform.parent = null;
        GameManager.instance.AddScore(20);
        Kill();
    }

    public void OnMouseDown()
    {
        DoDamage(0);
    }

    private void Kill()
    {
        Destroy(gameObject);
    }
}
