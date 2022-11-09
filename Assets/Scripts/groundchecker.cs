using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundchecker : MonoBehaviour

{
    public playermovement Elfa;


    void Awake()
    {
        Elfa = GameObject.Find("Elfa").GetComponent<playermovement>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Elfa.anim.SetBool("Saltar", false);
        Elfa.isGorounded = true;
    }


    void OnTriggerStay2D(Collider2D col)
    {
        Elfa.isGorounded = true;
        
    }

    void OnTriggerExit2D(Collider2D col)

    {
        Elfa.isGorounded = false;
    }
}