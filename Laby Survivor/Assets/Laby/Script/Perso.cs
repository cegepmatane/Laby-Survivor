using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perso : MonoBehaviour{
    public float health = 50;
    public float atk = 10;
    protected float maxHP;
    public bool canBeAttacked = true;
    public int secondsBeforeAttack = 1;
    // Start is called before the first frame update
    void Start(){
         maxHP = health;
    }

    // Update is called once per frame
    void Update(){
        
    }

    public virtual void TakeDamage(float damage){
        if (canBeAttacked){
            health -= damage;
            if (health < 0){
                health = 0;
            }
            waitBeforeAttack();
        }
    }

    /*
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
    }*/

    public void waitBeforeAttack(){
        canBeAttacked = false;
        StartCoroutine(attack());
    }

    IEnumerator attack(){
        yield return new WaitForSeconds(secondsBeforeAttack);
        canBeAttacked = true;
    }

    public float getMaxHP() {
        return maxHP;
    }

}
