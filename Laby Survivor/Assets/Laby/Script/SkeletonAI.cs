using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SkeletonAI : MonoBehaviour
{
    
    public GameObject player; 
    UnityEngine.AI.NavMeshAgent agent;
    public float distance;
    public float health;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance < 10){
            if( distance > 2.5f){
                agent.SetDestination(player.transform.position);
                //on regle la vitesse
                agent.speed = 0.7f;
                agent.acceleration = 10;
                agent.angularSpeed = 250;
                //on change l'animation
                GetComponent<Animator>().Play("DS_onehand_walk");
            }else{
                //on arrete le mouvement de l'agent
                agent.SetDestination(transform.position);
                //on attaque le joueur 
                //on change l'animation
                GetComponent<Animator>().Play("DS_onehand_attack_A");
                //on regle la vitesse d'attaque
                agent.speed = 0;
                agent.acceleration = 0;
                agent.angularSpeed = 0;
            }
        }else{
            //on arrete le mouvement de l'agent
            agent.SetDestination(transform.position);
            GetComponent<Animator>().Play("DS_onehand_idle_A");
        }

    }

    public void TakeDamage(float damage){
        if (health > 0){
        health -= damage;
            if (health <= 0){
                //on arrete le mouvement de l'agent
                agent.SetDestination(transform.position);
                //on detruit le zombie
                Destroy(gameObject, 2);
            }
        }
    }
}
