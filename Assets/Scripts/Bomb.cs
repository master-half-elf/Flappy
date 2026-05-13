using UnityEngine;

public class Bomb : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Comment 

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
