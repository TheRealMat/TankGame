using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCreation : MonoBehaviour
{
    public List<Object> MainTurrets = new List<Object>
    {

    };

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = Instantiate(MainTurrets[1], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        go.transform.parent = GameObject.Find("MainTurret").transform;
        go.transform.position = go.transform.parent.position;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
