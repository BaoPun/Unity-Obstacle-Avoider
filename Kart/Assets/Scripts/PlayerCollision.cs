using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Goal")
        {
            FindObjectOfType<GameManager>().CompleteLevel();
        }

        // If we hit an obstacle (that's not the ground)
        // Then don't move the player anymore
        if (collision.collider.tag == "Obstacle")
        { 
            //GetComponent<PlayerMovement>().enabled = false; // this is equivalent to the line below
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }

        
    }
}
