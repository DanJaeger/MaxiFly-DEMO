using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public abstract class Controller : MonoBehaviour
{
    public abstract void ReadInput(InputData data);

    protected Rigidbody2D rb;
    protected bool newInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
