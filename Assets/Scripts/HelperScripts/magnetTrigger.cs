using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnetTrigger : MonoBehaviour
{
    public Transform Player;
    void Start()
    {
        Player = GameObject.Find("Ball").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.isMagnet == true)
        {
            //after rhis distance if the coin left behind wont follow
            if (Vector3.Distance(transform.position,Player.position)<5)
            transform.position = Vector3.MoveTowards(transform.position, Player.position, 0.1f);
            //above code is for coin follow player wether it is far or near or we didnt catch it first
        }
        
    }
}
