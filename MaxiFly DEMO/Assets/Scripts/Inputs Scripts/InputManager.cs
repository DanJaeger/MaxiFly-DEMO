using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [Range(1,5)]public int buttonCount;

    public Controller controller;

    public void PassInput(InputData data)
    {
        controller.ReadInput(data);
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
