using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrincipal : MonoBehaviour{

    public List<string> inventaire;

    void Start()
    {
        inventaire = new List<string>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Collecte"))
        {
            string itemType = collision.gameObject.GetComponent<RecolteObjets>().itemType;
            print("Vous avez recolte un item:" + itemType);

            inventaire.Add(itemType);
            print("Inventaire:" + inventaire.Count);
            //items.Add(itemType);
            Destroy(collision.gameObject);
        }
    }
}
