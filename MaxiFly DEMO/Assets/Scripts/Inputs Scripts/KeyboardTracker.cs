using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardTracker : DeviceTracker
{
    public KeyCode[] buttonsKeys;

    private void Reset()
    {
        im = GetComponent<InputManager>();
        buttonsKeys = new KeyCode[im.buttonCount];
    }

    private void Update()
    {
        for (int i = 0; i < buttonsKeys.Length; i++)
        {
            if (Input.GetKey(buttonsKeys[i]))
            {
                data.buttons[i] = true;
                newData = true;
            }

        }


        //Check for Inputs
        if (newData)
        {
            im.PassInput(data);
            newData = false;
            data.Reset();

        }
    }
}
