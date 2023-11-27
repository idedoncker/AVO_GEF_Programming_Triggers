using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score = 0;
    int checkPoint = 0;

    /** Initialise singleton */
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            print("Singleton successfully initialized.");
        }
        else
        {
            print("Singleton already exists, destroying myself.");
            Destroy(gameObject);
        }
    }

    public void PrintMessage(string message)
    {
        print(message);
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        PrintMessage("score is " + score);
    }

    public void RegisterCheckPoint(int currentCheckPoint)
    {
        checkPoint = currentCheckPoint;
    }

    public int GetCheckPoint()
    {
        return checkPoint;
    }

    public int GetScore()
    {
        return score;
    }
}
