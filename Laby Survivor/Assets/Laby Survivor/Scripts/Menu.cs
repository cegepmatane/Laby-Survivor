using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public GameObject fenetreMultiple;
    public Text textTitre;

    private void Start()
    {
        textTitre.text = "Bienvenue dans LabySurvivor";
    }
    public void ButtonRecommencer()
    {
        Debug.Log("ButtonRecommenncer");

        SceneManager.LoadScene("SampleScene");
    }

    public void ButtonQuitter()
    {
        Debug.Log("ButtonQuitter");

        SceneManager.LoadScene("Menu");
    }

    public void ButtonJouer()
    {
        Debug.Log("ButtonJouer");

        SceneManager.LoadScene("SampleScene");
    }

    public void SetCreditsWindow(bool a_Stats)
    {
        Debug.Log(a_Stats);

        fenetreMultiple.SetActive(a_Stats);


        if (!a_Stats)
        {

        }
    }
}
