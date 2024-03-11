using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladd : MonoBehaviour
{
    void Start()
    {
        Applee myApplee = new Applee();

       
        myApplee.SayHello();
        myApplee.Chop();

        
        Fruitt myFruitt = new Applee();
        myFruitt.SayHello();
        myFruitt.Chop();
    }
}
