using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCreation : MonoBehaviour
{
    public List<Object> MainTurrets = new List<Object>
    {

    };
    public List<Object> Hulls = new List<Object>
    {

    };
    public int hullSelected = 0;
    public int mainTurretSelected = 0;
    GameObject mainTurret;
    GameObject hull;
    // Start is called before the first frame update
    void Start()
    {

        CreateHull();
        CreateTurret();
    }

    private void CreateHull()
    {
        // get position of the tank and then add the offset from the hull prefab
        Vector3 hullpos = GameObject.Find("ExampleTank").transform.position + (Hulls[hullSelected] as GameObject).transform.position;

        hull = Instantiate(Hulls[hullSelected], (hullpos), Quaternion.identity) as GameObject;
        hull.transform.parent = GameObject.Find("ExampleTank").transform;

    }
    private void CreateTurret()
    {
        // get position of the turret mount and then add the offset from the prefab
        Vector3 turretpos = GameObject.Find("MainTurret").transform.position + (MainTurrets[mainTurretSelected] as GameObject).transform.position;

        mainTurret = Instantiate(MainTurrets[mainTurretSelected], (turretpos), Quaternion.identity) as GameObject;
        mainTurret.transform.parent = GameObject.Find("MainTurret").transform;
    }

    public void TurretIterate(int iteration)
    {
        if (iteration > 0 && mainTurretSelected < MainTurrets.Count - 1)
        {
            mainTurretSelected++;
        }
        if (iteration < 0 && mainTurretSelected > 0)
        {
            mainTurretSelected--;
        }

        Destroy(mainTurret);

        CreateTurret();
    }
    public void HullIterate(int iteration)
    {
        if (iteration > 0 && hullSelected < Hulls.Count - 1)
        {
            hullSelected++;
        }
        if (iteration < 0 && hullSelected > 0)
        {
            hullSelected--;
        }
        mainTurret.transform.parent = null;
        Destroy(hull);

        CreateHull();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
