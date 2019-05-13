using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlanchette : MonoBehaviour
{

    public Animator anim;
    public bool touching = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        anim = GameObject.Find("planchette2").GetComponent<Animator>();

        if (touching)
        {
            anim.speed = 1;
        }
        else
        {
            anim.speed = 0;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Planchette")
        {
            touching = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag=="Planchette")
        {
            touching = false;
        }
    }
}
