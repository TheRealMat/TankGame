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
        go = Instantiate(MainTurrets[selected], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        go.transform.parent = GameObject.Find("MainTurret").transform;
        go.transform.position = go.transform.parent.position;

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

        go = Instantiate(MainTurrets[selected], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        go.transform.parent = GameObject.Find("MainTurret").transform;
        go.transform.position = go.transform.parent.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
