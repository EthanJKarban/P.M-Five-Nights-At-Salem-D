using UnityEngine;

public class TP : MonoBehaviour
{
    public Vector3 destination;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = destination;
            collision.GetComponent<Rigidbody2D>().linearVelocity = Vector3.zero;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(destination, 1);
        Gizmos.DrawLine(transform.position, destination);
    }
}

