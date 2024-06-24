using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Animator sadIdle;
    [SerializeField] Animator cryAnimator;
    


    bool isStill = true;
    public bool isGrounded;
    bool canJump;

    public Transform groundCheck;
    public LayerMask groundCheckLayer;


    void GroundChecker()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.15f, groundCheckLayer);

        if (isGrounded)
        {
            canJump = false;
        }

        else
        {
            canJump = true;
        }

    }

    void CryBird()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GroundChecker();
        animator.SetBool("jump", canJump);


    }
}
