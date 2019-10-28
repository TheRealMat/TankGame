using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player_NetworkSetup : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        if (isLocalPlayer)
        {
            GetComponent<TankMovement>().enabled = true;
            GetComponentInChildren<Camera>().enabled = true;
            //GetComponentInChildren<Turret>().enabled = true;
            //GetComponentInChildren<AudioListener>().enabled = true;
        }
    }


}
