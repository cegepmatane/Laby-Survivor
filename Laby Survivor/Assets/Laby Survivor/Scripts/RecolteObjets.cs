using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolteObjets : MonoBehaviour
{
    public string itemType;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var ennemie = collision.gameObject.GetComponent<Ennemie>();

        if (ennemie)
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
