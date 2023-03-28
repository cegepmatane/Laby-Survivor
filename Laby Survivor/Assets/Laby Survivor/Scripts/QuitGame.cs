using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        Application.Quit();
    }
}
