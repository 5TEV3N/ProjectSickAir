using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Score score;

    public float mouseRayDistance;
    public RaycastHit mouseHit;
    public Ray mouseRay;
    public Vector3 mousePosition;
    public GameObject hit;
    private LayerMask interactiveMask;

    private void Awake()
    {
        score = GameObject.FindGameObjectWithTag("BallTag").GetComponent<Score>();
        interactiveMask = LayerMask.GetMask("BallLayer");
    }


    private void Update()
    {
        DebugRaycast();
        FoundBallCheck();

        if (Input.GetMouseButtonDown(0))
        {
            if (FoundBallCheck() == true)
            {
                if (hitObject().transform.tag == "BallTag")
                {
                    score.ScoreKeeper();
                    score.rb.AddForce(transform.up* 10f,ForceMode.Impulse);
                }
            }
            else { print("Debug: Found Nothing"); }
        }
    }

    void DebugRaycast()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(mousePosition, mouseRay.direction * mouseRayDistance, Color.green);
    }

    public bool FoundBallCheck()
    {
        return Physics.Raycast(mouseRay, out mouseHit, mouseRayDistance, interactiveMask);
    }

    public GameObject hitObject()
    {
        hit = mouseHit.transform.gameObject;
        return hit;
    }
}