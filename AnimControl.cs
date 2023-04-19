using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    public Animator mAnimator;
    public GameObject Player;
    void Update()
    {

        if (mAnimator != null)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                mAnimator.SetTrigger("TrRun");
                Player.GetComponent<Animator>().Play("RunForward");
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                mAnimator.SetTrigger("TrRunBw");
                Player.GetComponent<Animator>().Play("RunBackWard");
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                mAnimator.SetTrigger("TrGather");
                Player.GetComponent<Animator>().Play("Gathering");
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                mAnimator.SetTrigger("TrJump");
                Player.GetComponent<Animator>().Play("Jump");
            }
        }
        
    }
}
