using UnityEngine;


public class PlayerCollition : MonoBehaviour
{

    public Movement Movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstical")
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();


        }
    }
}