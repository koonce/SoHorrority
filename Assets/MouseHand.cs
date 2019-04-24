using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHand : MonoBehaviour
{

    public float layer = 11f;
    public float offset = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        var pos = Input.mousePosition;
        pos.z = layer;
        pos.y = pos.y + offset;
        pos = Camera.main.ScreenToWorldPoint(pos);
        transform.position = pos;
    }
}
