using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    /** Initialise singleton */
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            print("Singleton successfully initialized.");
        } else {
            print("Singleton already exists, destroying myself.");
            Destroy(gameObject);
        }
    }

    public void PrintMessage(string message) {
        print(message);
    }
}
