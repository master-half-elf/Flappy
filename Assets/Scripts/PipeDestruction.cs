using UnityEngine;

public class PipeDestruction : MonoBehaviour
{
    [SerializeField] float scatterForce = 5f; //Cила рассыпания
    [SerializeField] string bombTag = "Weapon";
    [SerializeField] GameObject shatteredPipePrefab;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(bombTag))
        {
            GameObject shatteredPipe = Instantiate(shatteredPipePrefab, 
                transform.position, transform.rotation);

            foreach (Transform part in shatteredPipe.transform)
            {
                Rigidbody2D partRB = part.GetComponent<Rigidbody2D>();
                if (partRB != null)
                {
                    partRB.AddForce(new Vector2(Random.Range(-1f,1f), Random.Range(-1f,1f)) * 
                        scatterForce, ForceMode2D.Impulse);
                }
            }
            Destroy(gameObject);
        }
    }

}
