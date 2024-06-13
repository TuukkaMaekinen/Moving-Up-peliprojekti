using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdyControl : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;

    public Vector2 minPower;
    public Vector2 maxPower;

    TrajectoryLine tl;
    [SerializeField]  Animator animator;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;

    bool isStill = true;
    public bool isGrounded;
    bool canJump;

    public Transform groundCheck;
    public LayerMask groundCheckLayer;

    void GroundChecker()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.15f, groundCheckLayer);

        if (isGrounded )
        {
            canJump = false;
        }

        else
        {
            canJump = true;
        }

    }

        

    private void Start()
    {
        cam = Camera.main;
        tl = GetComponent<TrajectoryLine>();
    }

    private void Update()
    {
        GroundChecker();
        animator.SetBool("jump", canJump);

        if (rb.velocity == new Vector2(0, 0))
        {
            isStill = true;
        }
        else
        {
            isStill = false;
        }

        if (Input.GetMouseButtonDown(0) && isStill == true)
        {
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            startPoint.z = 15;
        }

        if (Input.GetMouseButton(0) && isStill == true)
        {
            Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            currentPoint.z = 15;
            tl.RenderLine(startPoint, currentPoint);
        }

        if (Input.GetMouseButtonUp(0) && isStill == true)
        {
            endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            endPoint.z = 15;

            force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
            rb.AddForce(force * power, ForceMode2D.Impulse);

            tl.EndLine();
            

        }
    }
}
