using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemie : MonoBehaviour
{
    public List<string> inventaire;

    public float vitesse = 2f;
    bool gauche = false;
    float tempMarche = 0f;
    float tempActuel = 0f;
    float arretAleatoire = 0f;
    float tempArretAleatoire = 0f;
    [SerializeField]
    float tempDeplacement = 1f;

    private void Start()
    {
        arretAleatoire = Random.Range(0, 10);
        tempArretAleatoire = Random.Range(0, 4);

        inventaire = new List<string>();
      
    }

    void Update()
    {
        tempActuel += Time.deltaTime;
        
        if (tempActuel > arretAleatoire)
        {
            float tempArretAleatoire = Random.Range(0, 100);
            if (tempActuel > arretAleatoire + tempArretAleatoire)
            {
                arretAleatoire = Random.Range(0, 10);
                tempArretAleatoire = Random.Range(0, 4);
                tempActuel = 0;
            }
        }
        else
        {
            tempMarche += Time.deltaTime;
            if (tempMarche > tempDeplacement)
            {
                gauche = !gauche;
                tempMarche = 0;
            }
            Vector2 forceAjouter = gauche ? new Vector2(vitesse * 1, 0) : new Vector2(vitesse * -1, 0);

            forceAjouter *= Time.deltaTime;

            transform.Translate(forceAjouter);
        }
    }

    public void dead()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Collecte"))
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
