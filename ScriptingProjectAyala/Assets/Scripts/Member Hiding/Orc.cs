using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy2
{
    //This hides the Enemy version.
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}
