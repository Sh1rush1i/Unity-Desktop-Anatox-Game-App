using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHore : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.Play("Gate1");
            anim.Play("Gate2");
        }
    }

}
    