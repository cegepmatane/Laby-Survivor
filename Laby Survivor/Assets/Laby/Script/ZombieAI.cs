using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class ZombieAI : Perso{
    public GameObject player; 
    NavMeshAgent agent;
    public float distance;
    public AudioSource audiosource;

    void Start(){
        agent = GetComponent<NavMeshAgent>();
        //on cherche le joueur
        player = GameObject.Find("XR Origin");
    }

    void Update(){

        if (health <= 0){
            //on arrete le mouvement de l'agent
            agent.SetDestination(transform.position);
            //on change l'animation
            GetComponent<Animator>().Play("Z_FallingBack");
            //on detruit le zombie
            Destroy(gameObject, 2);
        }else{
            //on repere le joueur si il est dans le champ de vision de l'agent qui sera de 25 
            distance = Vector3.Distance(player.transform.position, transform.position);
            if (distance <= 20){
                //on donne la position du joueur à l'agent
                agent.SetDestination(player.transform.position);
                if (distance > 12){
                    //on marche vers le joueur
                    agent.speed = 0.7f;
                    agent.acceleration = 10;
                    agent.angularSpeed = 250;
                    //on change l'animation
                    GetComponent<Animator>().Play("Z_Walk");
                }else if( distance > 1.0f){
                    //si la distance entre le joueur et l'agent est inférieure à 12 et supérieure à 1.1
                    //on court vers le joueur
                    agent.speed = 1.5f;
                    agent.acceleration = 2;
                    agent.angularSpeed = 250;
                    //on change l'animation
                    GetComponent<Animator>().Play("Z_Run");
                }else{
                    //on arrete le mouvement de l'agent
                    agent.SetDestination(transform.position);
                    //on attaque le joueur 
                    //on change l'animation
                    GetComponent<Animator>().Play("Z_Attack");
                    if (player.GetComponent<Perso>().canBeAttacked){
                        audiosource.Play();
                    }
                    player.GetComponent<Perso>().TakeDamage(atk);
                    //on regle la vitesse d'attaque
                    agent.speed = 0;
                    agent.acceleration = 0;
                    agent.angularSpeed = 0;
                    GetComponent<Animator>().speed = 0.7f;
                }
            }else{
                //on arrete le mouvement de l'agent
                agent.SetDestination(transform.position);
                GetComponent<Animator>().Play("Z_Idle");
            }
        }
    }

}