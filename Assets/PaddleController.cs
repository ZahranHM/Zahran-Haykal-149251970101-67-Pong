using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    public bool havepowerup = false;
    private float PUtimer;
    private float PUTpluser = 0;
    private int normalspeed;
    private Vector3 normalsize;

    void Start()
    {
        havepowerup = false;
        rig = GetComponent<Rigidbody2D>();
        normalspeed = speed;
        normalsize = transform.localScale;
    }

    void Update()
    {
        PUtimer += PUTpluser;
        if (PUtimer > 5)
        {
            if (speed != normalspeed)
            {
                speed = normalspeed;
            }
            if (transform.localScale != normalsize)
            {
                transform.localScale = normalsize;
            }
            PUTpluser = 0;
            PUtimer = 0;
        }

        // get input
        Vector2 movement = GetInput();

        // move object 
        MoveObject(movement);

        if (havepowerup)
        {
            PUTpluser = Time.deltaTime;
        }

        Vector2 GetInput()
        {
            if (Input.GetKey(upKey))
            {
                return Vector2.up * speed;
            }
            else if (Input.GetKey(downKey))
            {
                return Vector2.down * speed;
            }

            return Vector2.zero;
        }

        void MoveObject(Vector2 movement)
        {
            Debug.Log("TEST: " + movement);
            rig.velocity = movement;
        }

    }
}
