using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : Controller
{
    Vector2 playerVelocity;
    public float impulsePower = 2f;
    public float gravity = 2;

    public override void ReadInput(InputData data)
    {
       playerVelocity = Vector2.zero;

        if (data.buttons[0])
        {
            playerVelocity.y += impulsePower;
        }
        newInput = true;

    }

    private void LateUpdate()
    {
        if (!newInput)
        {
            playerVelocity = Vector2.zero;
            rb.gravityScale = gravity;
        }
        rb.velocity = playerVelocity;
        newInput = false;
    }

}
