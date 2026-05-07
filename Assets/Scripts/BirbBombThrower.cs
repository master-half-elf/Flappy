using UnityEngine;

public class BirbBombThrower : MonoBehaviour
{
    public GameObject birbBombPrefab;
    public Transform spawnPoint;
    public float throwForce = 10f;

    void OnAttack()
    {
        ThrowBirbBomb();
    }

    void ThrowBirbBomb()
    {
        GameObject bomb = Instantiate(birbBombPrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody2D bombRB = bomb.GetComponent<Rigidbody2D>();
        bombRB.AddForce(spawnPoint.right * throwForce);
    }

}
