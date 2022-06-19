using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSizeUpController : MonoBehaviour
{
    public Collider2D ball;
    public float multiply;
    public PowerUpManager manager;
    private GameObject thepaddle;

    private float PUPSiUTimer;
    private float PUPSiUTimerpluser = 0;

    void Update()
    {
        PUPSiUTimer += PUPSiUTimerpluser;
        if (PUPSiUTimer > 8)
        {
            DeactivatePUPaddleSizeUp(thepaddle, multiply);
            PUPSiUTimer -= PUPSiUTimer;
            PUPSiUTimerpluser = 0;
            manager.RemovePowerUp(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<BallController>().ActivatePUPaddleSizeUp(multiply);
            thepaddle = ball.GetComponent<BallController>().bouncer;
            PUPSiUTimerpluser = Time.deltaTime;
            transform.position = new Vector2(10, 10);
        }
    }

    private void DeactivatePUPaddleSizeUp(GameObject thepaddle, float multiply)
    {
        float temp = thepaddle.transform.localScale.y / multiply;
        thepaddle.transform.localScale -= new Vector3(0, (thepaddle.transform.localScale.y) - temp, 0);
    }
}
