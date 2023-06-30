using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtApples, txtVictoryCondition;
    [SerializeField] GameObject victoryCondition;

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

    private static PointManager instance;

    public static PointManager MyInstance
    {
        get
        {
            if (instance == null)
                instance = new PointManager();

            return instance;
        }
    }

    public void UpdateAppleUI(int _apples, int _victoryCondition)
    {
        txtApples.text = "Points: " + _apples + " / " + _victoryCondition;
    }

    public void ShowVictoryCondition(int _apples, int _victoryCondition)
    {
        victoryCondition.SetActive(true);
        txtVictoryCondition.text = "Point Not Enough";
    }

    public void HideVictoryCondition()
    {
        victoryCondition.SetActive(false);
    }
}

