using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpController : MonoBehaviour
{
    Rigidbody rg;
    [SerializeField] int jumpPower;
   
     bool is_grounded;
    void Start()
    {
        rg = GetComponent < Rigidbody >();
    }

    // Update is called once per frame
    void Update()
    {
        jump();

    }

    void jump()
    {
        if((Input.GetKeyDown(KeyCode.Space))&&is_grounded==true)
        {
            rg.velocity = new Vector3(rg.velocity.x, jumpPower);
        }
        is_grounded = false;
    }
    private void OnCollisionStay(Collision collision)
    {

        is_grounded = true;
    }

}
