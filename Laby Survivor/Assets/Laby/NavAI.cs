using UnityEngine;
using UnityEngine.AI;

public class NavAI : MonoBehaviour{
    public GameObject player; 
    NavMeshAgent agent;

    void Start(){
        agent = GetComponent<NavMeshAgent>();
    }

    void Update(){
        //on donne la position du joueur à l'agent mais avec un decalage de 1
        agent.SetDestination(player.transform.position /*+ new Vector3(1,1,1)*/);
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance > 12){
            //on marche vers le joueur
            agent.speed = 3;
            agent.acceleration = 5;
            agent.angularSpeed = 110;
            //on change l'animation
            GetComponent<Animator>().Play("Z_walk");
        }else if( distance > 1.1f){
            //si la distance entre le joueur et l'agent est inférieure à 12 et supérieure à 1.1
            //on court vers le joueur
            agent.speed = 4;
            agent.acceleration = 7;
            agent.angularSpeed = 120;
            //on change l'animation
            GetComponent<Animator>().Play("Z_Run");
        }else{
            //on attaque le joueur 
            agent.speed = 0;
            agent.acceleration = 0;
            agent.angularSpeed = 0;
            //on change l'animation
            GetComponent<Animator>().Play("Z_Attack");
            //on regle la vitesse d'attaque
            GetComponent<Animator>().speed = 0.7f;
        }
    }  
 
}