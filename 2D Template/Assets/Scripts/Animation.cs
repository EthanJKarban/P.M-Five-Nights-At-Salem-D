using UnityEngine;
using System.Collections;
using Unity.VisualScripting;



public class Animations : MonoBehaviour
{
    [SerializeField] public SpriteRenderer spriteRenderer;
    [SerializeField] public Animator animator;
    public KeyCode Left = KeyCode.A;
    public KeyCode Right = KeyCode.D;
    public KeyCode Up = KeyCode.W;
    public KeyCode Down = KeyCode.S;
 

    private Vector2 movementDirection;

    void Start()
    {
        
    }

    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

         if (Input.GetKey(Up)) //up
        { 
        animator.SetBool("isWalkingUp", true);
        animator.SetBool("isWalkingDown", false);
        animator.SetBool("isWalkingLeft", false);
        animator.SetBool("isWalkingRight", false);
         }
        if (Input.GetKey(Down))//down
        {
            animator.SetBool("isWalkingDown", true);
            animator.SetBool("isWalkingUp", false);
            animator.SetBool("isWalkingLeft", false);
            animator.SetBool("isWalkingRight", false);
        }
        if (Input.GetKey(Right)) //right
        {
            animator.SetBool("isWalkingRight", true);
            animator.SetBool("isWalkingUp", false);
            animator.SetBool("isWalkingLeft", false);
            animator.SetBool("isWalkingDown", false);
        }
        if (Input.GetKey(Left)) //left
        {
            animator.SetBool("isWalkingLeft",true);
            animator.SetBool("isWalkingRight", false);
            animator.SetBool("isWalkingDown", false);
            animator.SetBool("isWalkingUp", false);
        }
        if (movementDirection.x == 0 && movementDirection.y == 0)
        {
            animator.SetBool("isIdle", true);
            animator.SetBool("isWalkingRight", false);
            animator.SetBool("isWalkingDown", false);
            animator.SetBool("isWalkingUp", false);
            animator.SetBool("isWalkingLeft", false);
        }
        else
        {
            animator.SetBool("isIdle", false);

        }
    }
}
