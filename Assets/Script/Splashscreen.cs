using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splashscreen : MonoBehaviour
{
    public float wait_time= 5f;

    void start()
    {
        StartCoroutine(Wait_for_Splashscreen());
    }

    IEnumerator Wait_for_Splashscreen()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(1);
    }
}
