using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int collectedApples, victoryCondition = 1000;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    private static GameManager instance;

    public static GameManager MyInstance
    {
        get{
            if (instance == null)
                instance = new GameManager();

            return instance;
        }
    }

    private void Start()
    {
        PointManager.MyInstance.UpdateAppleUI(collectedApples, victoryCondition);
    }

    public void AddAplles(int _apples)
    {
        collectedApples += _apples;
        PointManager.MyInstance.UpdateAppleUI(collectedApples, victoryCondition);
    }

    public void FinishLevel1()
    {
        if (collectedApples >= victoryCondition)
        {
            SceneManager.LoadScene("LevelMenu");
        }
        else
        {
            PointManager.MyInstance.ShowVictoryCondition(collectedApples, victoryCondition);
        }
    }

}
