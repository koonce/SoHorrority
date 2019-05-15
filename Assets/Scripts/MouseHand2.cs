using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHand2 : MonoBehaviour
{

    public float layer = 11f;
    public float offset = 0;

    float speed = 10f;
    float amount = 1f;

    public GameObject cup;

    int drinks;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        drinks = this.gameObject.GetComponent<FillUpCup>().drinks;

        Cursor.visible = false;
        var pos = Input.mousePosition;
        pos.z = layer;
        pos.y = pos.y + offset;
        pos = Camera.main.ScreenToWorldPoint(pos);
        pos = new Vector3(pos.x, pos.y * 2, pos.z);

        if (drinks > 3)
        {
            pos.x += Mathf.Sin(Time.time * speed) * amount;
        }

        transform.position = pos;
    }
}