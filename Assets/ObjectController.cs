using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Shoots spawned objects towards the player
 */
public class ObjectController : MonoBehaviour
{
    public float speed; //speed the object shoots towards the player
    public GameObject Player;
    public int damage;

    // Update is called once per frame
    void FixedUpdate()
    {
        // need to keep a reference to player
        Transform player = Player.transform;

        // Moves the pipe towards the player every physics frame
        // direction = target - origin;
        Vector3 directionTo = player.position - transform.position;
        transform.position += directionTo.normalized * speed;

        //If the enemy reaches the player...
        float d = directionTo.magnitude;
        if (d < 1f) {
            Attack();
        }
    }

    //The enemy attacks the player
    void Attack(){
        //Lower player's health
        PlayerHealth.health -= damage;
        Destroy(gameObject);
    }
}
