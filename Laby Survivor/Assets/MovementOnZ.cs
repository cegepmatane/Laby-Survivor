using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOnZ : MonoBehaviour
{
    private Transform transform;

    private void Start() {
        transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Translate(new Vector3(0f,0f,1f));
    }
}
