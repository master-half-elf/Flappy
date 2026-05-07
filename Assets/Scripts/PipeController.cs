using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < -12f)
        {
            Destroy(gameObject);
        }   //Способ по позиции

        // 2 вариант - сделать простой таймер 

    }

    /*void OnTriggerEnter2D(Collider2D other)  //3 вариант
    {
        Destroy(gameObject);
    }*/
}
