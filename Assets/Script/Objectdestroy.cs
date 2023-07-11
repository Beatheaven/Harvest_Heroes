using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectdestroy : MonoBehaviour
{
    private GameObject destroyobject;

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
