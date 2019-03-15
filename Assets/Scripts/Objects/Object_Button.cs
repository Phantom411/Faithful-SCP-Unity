using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// :{)

public class Object_Button : Object_Interact
    public GameObject Door01, Door02;
    float deactivate;
    public bool activated;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        /*if (function == 1)
        {
            deactivate -= Time.deltaTime;
            if (deactivate <= 0)
                activated = false;
        }*/
    }

    public override void Pressed()
    {
        if (function == 0)
        {
            Door01.GetComponent<Object_Door>().DoorSwitch();
            if (Door02 != null)
                Door02.GetComponent<Object_Door>().DoorSwitch();
        }
        if (function == 1)
        {
            deactivate = 1.0f;
                activated = true;
        }
    }
    
    public override void Hold()
    {
    }
}
