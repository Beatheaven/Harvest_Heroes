using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
 public GameObject SmashEffect;
    void OnMouseDown()
    {
        Destroy(gameObject);
    }

     protected virtual void Collected()
 {
    //override
 }
}
