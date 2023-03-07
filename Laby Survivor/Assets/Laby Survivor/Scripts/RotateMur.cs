using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMur : MonoBehaviour
{
    Rigidbody2D rigidbod;

    private void Awake()
    {
        rigidbod = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            rigidbod.AddTorque(70, ForceMode2D.Impulse);
        }
        else
        {
            Destroy(gameObject, 5);
        }

    }
}
