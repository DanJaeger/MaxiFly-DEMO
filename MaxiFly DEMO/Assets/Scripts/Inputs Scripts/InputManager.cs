using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public void PassInput(InputData data)
    {

    }
}

public struct InputData
{
    public bool[] buttons;

    public InputData(int buttonCount)
    {
        buttons = new bool[buttonCount];
    }

    public void Reset()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = false;
        }
    }

}
