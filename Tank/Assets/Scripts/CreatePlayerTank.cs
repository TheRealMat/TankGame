using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CreatePlayerTank : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        GameObject children = GameObject.Find("ExampleTank").transform.GetChild(0).gameObject;

        children.transform.position = transform.position;
        children.transform.parent = transform;
        Destroy(GameObject.Find("ExampleTank"));

        gameObject.GetComponent<NetworkTransformChild>().target = GameObject.Find("MainTurret").transform;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
