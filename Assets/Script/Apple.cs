using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Collectable
{
    [SerializeField] int appleValue = 250;

    protected override void Collected()
    {
        GameManager.MyInstance.AddAplles(appleValue);
        Destroy(this.gameObject);
    }
}
