using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perso : MonoBehaviour{
    public float health = 20;
    public float atk = 10;
    public bool canBeAttacked = true;
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        
    }

    public virtual void TakeDamage(float damage){
        health -= damage;
        if (health <= 0){
            //le perso meurt
            //on l'affiche dans la console
            Debug.Log("Perso is dead");
        }
    }

    public virtual void OnCollisionEnter(Collision collision){
        GameObject perso = collision.gameObject;
        if (perso.tag == "Player"){
            Perso instance = perso.GetComponent<Perso>();
            if (instance.canBeAttacked){
                Debug.Log("Player is attacked");
                instance.TakeDamage(atk);
            }
        }else if (perso.tag == "Monstre"){
            //on detruit le monstre
            Destroy(perso);
            Debug.Log("Monstre is dead");
        }
    }
}
