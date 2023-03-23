using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolteObjets : MonoBehaviour
{
    public string itemType;
    private void OnTriggerEnter(Collider collision)
    {
        var ennemie = collision.gameObject.GetComponent<Ennemie>();

        if (ennemie)
        {
            Destroy(gameObject);
        }
    }
}
