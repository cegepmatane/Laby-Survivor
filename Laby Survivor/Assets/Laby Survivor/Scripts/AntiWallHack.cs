using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiWallHack : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
{
   if(other.tag == "Player")
   {
        Debug.Log("Player détecté");
      // Empêcher le joueur de se déplacer dans cette direction
      other.GetComponent<CharacterController>().enabled = false;
   }
}

void OnTriggerExit(Collider other) {
   if(other.tag == "Player")
    {
      // Réactiver le CharacterController
      other.GetComponent<CharacterController>().enabled = true;
    }
    }
}
