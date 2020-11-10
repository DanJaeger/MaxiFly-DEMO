using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardTracker : DeviceTracker
{
    
    private void Update()
    {
        //Check for Inputs
        if (newData)
        {
            im.PassInput(data);
            newData = false;
            data.Reset();
        }
    }


}
