using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float upForce = 200f;
    bool isDead;
    Rigidbody2D birdRB2D;

    [SerializeField] float maxTiltAngle = 30f; //Максимальный угол наклона вверх
    [SerializeField] float minTiltAngle = -45f;  //Минимальный угол наклона вниз
    [SerializeField] float tiltSmooth = 4f; //Cкорость наклона
    float tiltAngle;

    void Start()
    {
        birdRB2D = GetComponent<Rigidbody2D>();
    }
    void OnJump()
    {
        if (!isDead)
        {
            birdRB2D.linearVelocity = Vector2.zero;
            birdRB2D.AddForce(new Vector2(0f, upForce));
        }
    }
    void Update()
    { 
        if (birdRB2D.linearVelocity.y > 0)
        {
            tiltAngle = maxTiltAngle;
        }
        else
        {
            tiltAngle = minTiltAngle;
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, tiltAngle),
            tiltSmooth * Time.deltaTime);  //ВОТ ЭТОЙ

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        transform.rotation = Quaternion.Euler( 0f, 0f, -90f);
        birdRB2D.linearVelocity = Vector2.zero;
    }

}
