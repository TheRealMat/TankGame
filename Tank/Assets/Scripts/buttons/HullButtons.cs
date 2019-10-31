using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HullButtons : MonoBehaviour
{
    public int value;
    public void DoTheThing()
    {
        GameObject.Find("TankCreator").GetComponent<TankCreation>().HullIterate(value);
    }
}
