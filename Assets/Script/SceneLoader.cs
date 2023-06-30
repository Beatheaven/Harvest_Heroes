using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void load_game()
    {
        SceneManager.LoadScene("Level_Select");
    }

    public void load_Setting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void load_lv1()
    {
    SceneManager.LoadScene("Lv1");
    }

    public void load_about()
    {
        SceneManager.LoadScene("about");
    }
}
