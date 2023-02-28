using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    protected float damage;
    public AudioSource audiosource;

    private void OnCollisionEnter(Collision collision) {

        // If weapon hit an enemy
        if (collision.gameObject.layer == 8) {
            if (collision.gameObject.getComponent<Perso>.canBeAttacked) {
                collision.gameObject.getComponent<Perso>.TakeDamage(damage);
                audiosource.Play();
            }
        }
    }

}
