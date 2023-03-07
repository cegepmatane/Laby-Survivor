using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainPivot : MonoBehaviour
{
    public float direction = 3f;
    public float vitesse = 2f;
    public float maxDistance1 = 4f;
    public float maxDistance2 = -4f;

    bool bouge = true;

    private void Update()
    {
        if (transform.position.x > maxDistance1)
        {
            bouge = false;
        }
        if(transform.position.x < maxDistance2)
        {
            bouge = true;
        }
        if (bouge)
        {
            transform.position = new Vector2(transform.position.x + vitesse * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - vitesse * Time.deltaTime, transform.position.y);
        }
    }
}
