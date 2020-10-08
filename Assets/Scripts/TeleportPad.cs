using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPad : MonoBehaviour
{
    public Vector2 sendToPos = Vector2.zero;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        coll.gameObject.transform.position = sendToPos;
    }

}
