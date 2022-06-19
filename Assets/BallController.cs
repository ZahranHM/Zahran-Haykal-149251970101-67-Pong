using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D rig;
    public List<GameObject> paddles;
    public GameObject bouncer;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    void Update()
    {
        if (transform.position.x < -4)
        {
            bouncer = paddles[0];
        }
        if(transform.position.x > 4)
        {
            bouncer = paddles[1];
        }
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 1);
    }

    public void ActivatePUBallSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    public void ActivatePUPaddleSpeedUp(int multiply)
    {
        bouncer.GetComponent<PaddleController>().speed *= multiply;
    }

    public void ActivatePUPaddleSizeUp(float multiply)
    {
        float temp = bouncer.transform.localScale.y * multiply;
        bouncer.transform.localScale += new Vector3(0, -(bouncer.transform.localScale.y)+temp, 0);
    }

}
