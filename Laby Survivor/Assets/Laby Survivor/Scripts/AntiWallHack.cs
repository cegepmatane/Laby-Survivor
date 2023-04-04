using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiWallHack : MonoBehaviour
{
    public static int walls = 0;
    private GameObject UIAntiWallhack;
    private GameObject player;
    private Vector3 beforeWallColl;

    void Start() {
        UIAntiWallhack = GameObject.Find("AntiWallhack");
        player = GameObject.Find("CompleteXROrigin");
        UIAntiWallhack.SetActive(false);
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag == "Wall") {
            walls++;
            Debug.Log("Camera détectée");
            beforeWallColl = player.transform.position;
            UIAntiWallhack.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.tag == "Wall"){
            walls--;
            if (walls <= 0) {
                UIAntiWallhack.SetActive(false);
                player.transform.position = beforeWallColl;
            }
        }
    }
}
