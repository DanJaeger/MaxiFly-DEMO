using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : Controller
{
    Vector2 playerVelocity;
    public float impulsePower = 2f;
    public float fallMultiplier = 2f;

    public override void ReadInput(InputData data)
    {
       playerVelocity = Vector2.zero;

        if (data.buttons[0])
        {
            playerVelocity += Vector2.up * impulsePower;
        }
        newInput = true;

    }

    private void LateUpdate()
    {
        if (!newInput)
        {
            playerVelocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
        }
        Mathf.Clamp(playerVelocity.y, -7f, 7f);
        Debug.Log(rb.velocity);
        rb.velocity = playerVelocity;
        newInput = false;
    }

}
