using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public GameObject SmashEffect;
    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantitate(SmashEffect, transform.position, Qaternio.identity);
    }

    [SerializeField] int appleValue = 250;

    protected override void Collected()
    {
        GameManager.MyInstance.AddAplles(appleValue);
        Destroy(this.gameObject);
    }
}
