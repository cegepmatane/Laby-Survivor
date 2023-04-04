using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiWallHack : MonoBehaviour
{
    public static int walls = 0;
    private GameObject UIAntiWallhack;

    void Start() {
        UIAntiWallhack = GameObject.Find("AntiWallhack");
        UIAntiWallhack.SetActive(false);
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag == "Wall") {
            walls++;
            Debug.Log("Camera détectée");
            GetComponentInParent<DynamicMoveProvider>().enabled = false;
            UIAntiWallhack.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.tag == "Wall"){
            walls--;
            if (walls <= 0) {
                GetComponentInParent<DynamicMoveProvider>().enabled = true;
                UIAntiWallhack.SetActive(false);
            }
        }
    }
}
