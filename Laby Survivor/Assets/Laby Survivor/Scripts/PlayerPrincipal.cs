using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrincipal : MonoBehaviour{

    public List<string> inventaire;

    public void start()
    {
        inventaire = new List<string>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
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