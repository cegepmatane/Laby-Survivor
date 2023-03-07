using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolteObjets : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var ennemie = collision.gameObject.GetComponent<Ennemie>();

        if (collision.gameObject.layer == 7)
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 5);
        }
    }   
}
