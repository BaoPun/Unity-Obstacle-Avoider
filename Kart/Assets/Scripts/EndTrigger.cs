using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager manager;


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Player")
            manager.CompleteLevel();
    }
}
