using UnityEngine;

public class Bomb : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
