using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGetChild : MonoBehaviour
{
    private void Awake()
    {
        GameObject gun = GameObject.FindGameObjectWithTag("TurretChild");
        if (gun != null)
        {
            // what a fucking mess
            gun.transform.parent = transform;
            int turretselected = GameObject.Find("TankCreator").GetComponent<TankCreation>().mainTurretSelected;
            gun.transform.position = transform.position + (GameObject.Find("TankCreator").GetComponent<TankCreation>().MainTurrets[turretselected] as GameObject).transform.position;



        }
    }
}
