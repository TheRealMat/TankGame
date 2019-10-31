using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretButtons : MonoBehaviour
{
    public int value;
    public void DoTheThing()
    {
        GameObject.Find("TankCreator").GetComponent<TankCreation>().Iterate(value);
        Debug.Log("unga");
    }

}
