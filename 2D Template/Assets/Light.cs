using System.Runtime.CompilerServices;
using UnityEngine;

public class Light : MonoBehaviour
{
    private KeyCode Left = KeyCode.A;
    private KeyCode Right = KeyCode.D;
    private KeyCode Up = KeyCode.W;
    private KeyCode Down = KeyCode.S;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Left))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetKey(Right))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        if (Input.GetKey(Down))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        if (Input.GetKey(Up))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 1);
        }
    }


    


}
