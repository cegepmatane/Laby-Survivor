using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMainScene : MonoBehaviour
{
    public Animator transition;

    void OnTriggerEnter(Collider other) {
        StartCoroutine(SceneChange());
    }

    IEnumerator SceneChange() {
        if (transition != null) {
            transition.SetTrigger("levelChange");
        }

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(0);
    }
}
