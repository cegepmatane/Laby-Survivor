using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : Perso {

    public Animator transition;

    void Update() {
        if (health <= 0) {
            transition.SetTrigger("levelChange");
        }

        new WaitForSeconds(1);

        SceneManager.LoadScene(2);
    }
}
