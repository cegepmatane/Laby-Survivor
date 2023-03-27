using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SkeletonAI : Perso{
    
    public GameObject player; 
    NavMeshAgent agent;
    public float distance;
    public AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0){
            //on arrete le mouvement de l'agent
            agent.SetDestination(transform.position);
            //on change l'animation
            GetComponent<Animator>().Play("DS_onehand_idle_A");
            //on detruit le zombie
            Destroy(gameObject, 2);
        }else{
            distance = Vector3.Distance(player.transform.position, transform.position);
            if (distance < 10){
                if( distance > 2.0f){
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
                    if (player.GetComponent<Perso>().canBeAttacked){
                        audiosource.Play();
                    }
                    player.GetComponent<Perso>().TakeDamage(atk);
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

    }

}
