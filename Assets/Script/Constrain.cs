using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constrain : MonoBehaviour
{
    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
    }
}