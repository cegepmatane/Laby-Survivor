using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour{

    public GameObject zombie;

    void OnTriggerEnter(Collider other){

        if(other.gameObject.tag == "Player"){
            zombie.GetComponent<NavMeshAgent>().SetDestination(other.transform.position);
            zombie.GetComponent<Animator>().Play("Z_walk"); 
        }
    }

    void OnTriggerExit(Collider other){

        if(other.gameObject.tag == "Player"){
            zombie.GetComponent<NavMeshAgent>().SetDestination(transform.position);
        }
    }

}