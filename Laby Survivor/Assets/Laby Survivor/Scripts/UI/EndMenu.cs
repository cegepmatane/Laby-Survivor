using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{

    public Animator transition;

    public void Restart() {

        if (transition != null) {
            transition.SetTrigger("levelChange");
        }
        
        new WaitForSeconds(1);

        SceneManager.LoadScene(0);
    }

    public void QuitGame() {

        if (transition != null) {
            transition.SetTrigger("levelChange");
        }
        
        new WaitForSeconds(1);

        Application.Quit();
    }
}
