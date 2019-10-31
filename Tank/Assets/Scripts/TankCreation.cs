using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCreation : MonoBehaviour
{
    public List<Object> MainTurrets = new List<Object>
    {

    };

    int mainSelected = 0;
    GameObject mainTurret;
    // Start is called before the first frame update
    void Start()
    {
        CreateTurret();
    }
    private void CreateTurret()
    {
        // get position of the turret mount and then add the offset from the prefab
        Vector3 turretpos = GameObject.Find("MainTurret").transform.position + (MainTurrets[mainSelected] as GameObject).transform.position;

        mainTurret = Instantiate(MainTurrets[mainSelected], (turretpos), Quaternion.identity) as GameObject;
        mainTurret.transform.parent = GameObject.Find("MainTurret").transform;
    }



    public void Iterate(int iteration)
    {
        if (iteration > 0 && mainSelected < MainTurrets.Count - 1)
        {
            mainSelected++;
        }
        if (iteration < 0 && mainSelected >= MainTurrets.Count - 1)
        {
            mainSelected--;
        }

        Destroy(mainTurret);

        CreateTurret();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
