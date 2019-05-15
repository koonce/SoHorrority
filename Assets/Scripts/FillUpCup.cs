using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillUpCup : MonoBehaviour
{

    bool cupFull = false;

    public Sprite fillCup, emptyCup, bloodCup;

    public int drinks = 0;

    float speed = 1.0f; //how fast it shakes
    float amount = 1.0f; //how much it shakes

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!cupFull)
        {
            if (transform.position.y < -11)
            {
                if (drinks > 5)
                {
                    GetComponent<SpriteRenderer>().sprite = bloodCup;
                }
                else
                {
                    GetComponent<SpriteRenderer>().sprite = fillCup;
                }
                cupFull = true;
            }
        }

        if (cupFull)
        {
            if (transform.position.y > 8)
            {
                GetComponent<SpriteRenderer>().sprite = emptyCup;
                drinks++;
                cupFull = false;
            }
        }


    }
}
