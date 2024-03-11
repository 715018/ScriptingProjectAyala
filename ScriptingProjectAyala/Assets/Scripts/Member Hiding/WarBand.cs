using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy2 = new Enemy2();
        Humanoid orc = new Orc();

       
        human.Yell();
        enemy2.Yell();
        orc.Yell();
    }
}
