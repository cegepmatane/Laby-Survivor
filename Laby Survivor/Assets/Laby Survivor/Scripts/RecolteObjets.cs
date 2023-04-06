using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolteObjets : MonoBehaviour
{
    public string itemType;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 7) {
            if (collision.gameObject.GetComponent<Perso>().health <= collision.gameObject.GetComponent<Perso>().getMaxHP() - 10) {
                collision.gameObject.GetComponent<Perso>().health = collision.gameObject.GetComponent<Perso>().health + 10;
                Destroy(gameObject);
            } else {
               if (collision.gameObject.GetComponent<Perso>().health < collision.gameObject.GetComponent<Perso>().getMaxHP()) {
                    collision.gameObject.GetComponent<Perso>().health = collision.gameObject.GetComponent<Perso>().getMaxHP();
                    Destroy(gameObject);
               }
            }
            
        }

    }
}
