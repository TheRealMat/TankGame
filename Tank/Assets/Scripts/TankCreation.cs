using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCreation : MonoBehaviour
{
    public List<Object> MainTurrets = new List<Object>
    {

    };

    int selected = 0;
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        GameObject offset = MainTurrets[selected] as GameObject;

        Vector3 turretpos = GameObject.Find("MainTurret").transform.position + offset.transform.position;

        go = Instantiate(MainTurrets[selected], (turretpos), Quaternion.identity) as GameObject;
        go.transform.parent = GameObject.Find("MainTurret").transform;


    }
    public void Iterate(int iteration)
    {
        if (iteration > 0 && selected < MainTurrets.Count - 1)
        {
            selected++;
        }
        if (iteration < 0 && selected >= MainTurrets.Count - 1)
        {
            selected--;
        }

        Destroy(go);

        GameObject offset = MainTurrets[selected] as GameObject;

        Vector3 turretpos = GameObject.Find("MainTurret").transform.position + offset.transform.position;

        go = Instantiate(MainTurrets[selected], (turretpos), Quaternion.identity) as GameObject;
        go.transform.parent = GameObject.Find("MainTurret").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
