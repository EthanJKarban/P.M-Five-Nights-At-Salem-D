using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode Left = KeyCode.A;
    public KeyCode Right = KeyCode.D;
    public KeyCode Up = KeyCode.W;
    public KeyCode Down = KeyCode.S;
    public KeyCode jump = KeyCode.W;
    [SerializeField] private float speed = 3, jumpHeight = 15, maxSpeed = 10;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(Left))
        {


            _rb.AddForce(Vector2.left * speed * Time.deltaTime);

        }

        if (Input.GetKey(Right))
        {

            _rb.AddForce(Vector2.right * speed * Time.deltaTime);

        }

        if (Input.GetKey(Up))
        {

            _rb.AddForce(Vector2.up * speed * Time.deltaTime);

        }
        if (Input.GetKey(Down))
        {

            _rb.AddForce(Vector2.down * speed * Time.deltaTime);

        }

        if (_rb.linearVelocity.x > maxSpeed)
            _rb.linearVelocity = new Vector2(maxSpeed, _rb.linearVelocity.y);
        if (_rb.linearVelocity.x < -maxSpeed)
            _rb.linearVelocity = new Vector2(maxSpeed, _rb.linearVelocity.y);
    }
}
    
