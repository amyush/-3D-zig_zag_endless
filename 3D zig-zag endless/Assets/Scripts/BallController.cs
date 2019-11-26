using UnityEngine;
using System.Collections;

class BallController : MonoBehaviour
{
    [SerializeField] private float speed;

    bool started;
    bool gameOver;
    Rigidbody rigidbody;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        started = false; gameOver = false;
    }

    void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rigidbody.velocity = new Vector3(speed, 0, 0);
                started = true;
            }
        }
        if (!Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            gameOver = true;
            rigidbody.velocity = new Vector3(0, -25f, 0);
            Camera.main.GetComponent<CameraFollow>().gameOver = true;
        }
        if (Input.GetMouseButtonDown(0) && !gameOver)
        { // to check if this runs when the mouse click happens for the first time // to be removed Debug.log("started = " + started); Debug.log("BallController.cs file at 38 & 39"); switchDirection(); } }
            switchDirection();
        }
    }

    void switchDirection()
    {
        if (rigidbody.velocity.z > 0)
        {
            rigidbody.velocity = new Vector3(speed, 0, 0);
        }
        else if (rigidbody.velocity.x > 0)
        {
            rigidbody.velocity = new Vector3(0, 0, speed);
        }
    }
}