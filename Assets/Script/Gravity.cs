using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
    }}
