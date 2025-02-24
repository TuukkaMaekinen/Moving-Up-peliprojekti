using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BirdyControl : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;

    public Vector2 minPower;
    public Vector2 maxPower;

    TrajectoryLine tl;
    [SerializeField]  Animator animator;
    public float fallvalue;

    Camera cam;
    Camera cam2;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;

    bool isStill = true;
    public bool isGrounded;
    bool canJump;
    bool isFalling;
    bool isCrying;

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

    //private void OnGUI()
    //{
    //    GUIStyle myStyle = new GUIStyle();
    //    myStyle.fontSize = 60;
    //    myStyle.normal.textColor = Color.yellow;
    //private void OnGUI()
    //{
    //    GUIStyle myStyle = new GUIStyle();
    //    myStyle.fontSize = 60;
    //    myStyle.normal.textColor = Color.yellow;

    //    GUI.Label(new Rect(100, 100, 100, 20), rb.velocity.y.ToString(), myStyle);
    //    GUI.Label(new Rect(100, 200, 100, 20), isFalling.ToString(), myStyle);

    //}

    private void Start()
    {
        cam = Camera.main;

        Camera.main.aspect = 1280f / 1920f;
        tl = GetComponent<TrajectoryLine>();
    }

    private void Update()
    {
        GroundChecker();
        animator.SetBool("jump", canJump);


        if (rb.velocity == new Vector2(0, 0))
        {
            isStill = true;
            isFalling = false;
            isCrying = true;
        }
        else
        {
            isStill = false;
            
        }
        
        animator.SetBool("fall", isFalling);

        if (rb.velocity.y < -fallvalue)
        {
            isFalling = true;
        }

        animator.SetBool("cry", isCrying);

        if (rb.velocity == new Vector2(0, 0))
        {
            isCrying = true;
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
            animator.SetBool("jump", true);

            tl.EndLine();
            

        }



        //if (rb.velocity.x > 0)
        //{
        //    transform.localScale = new(-1, transform.localScale.y);
        //}
        //else if (rb.velocity.x < 0)
        //{
        //    transform.localScale = new(1, transform.localScale.y);
        //}

        float threshold = 0.1f;

        if (rb.velocity.x > threshold)
        {
            transform.localScale = new Vector2(-1, transform.localScale.y);
        }
        else if (rb.velocity.x < -threshold)
        {
            transform.localScale = new Vector2(1, transform.localScale.y);
        }
    }
}
