using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitCheckPoint : MonoBehaviour
{
    [SerializeField] Transform[] checkPoints;
    // List<Transform> is also a possibility but costs more in execution time when manipulating

    // Start is called before the first frame update
    void Start()
    {
        UpdateCheckPointIndices();
        SnapToCheckPoint();
    }

    public void SnapToCheckPoint()
    {
        int index = GameManager.instance.GetCheckPoint();
        GetComponent<Rigidbody>().position = checkPoints[index].position;
    }

    /* Automatically sets the check point values to the assigned check points */
    void UpdateCheckPointIndices()
    {
        for (int i = 0; i < checkPoints.Length; i++) {
            checkPoints[i].GetComponent<SetCheckPoint>().setCheckPoint = i;
        }
    }
}
