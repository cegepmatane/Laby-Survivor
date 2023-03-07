using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApparaitObjets : MonoBehaviour
{
    public GameObject CeriseApparait;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(CeriseApparait, transform.position, transform.rotation);
    }
}
