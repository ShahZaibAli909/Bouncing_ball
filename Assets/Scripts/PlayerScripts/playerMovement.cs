using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public static bool isMagnet;
    public int points;
    private Rigidbody myBody;
    public float walk_Speed = 3.0f;
    public float z_Speed = 2.0f;
    public float rotation_Y = -90f;
    //void Update()
    //{
    //    transform.Rotate(90 * Time.deltaTime, 0, 0);
    //}
    void Awake()
    {
        isMagnet = false;
        myBody = GetComponent<Rigidbody>();
        
    }

  
   
    void FixedUpdate()
    {
        DetectMovement();
    }
    void DetectMovement()
    {
        myBody.velocity = new Vector3(
            Input.GetAxisRaw("Vertical") * (-walk_Speed), myBody.velocity.y,
            Input.GetAxisRaw("Horizontal") * (-z_Speed));
    }
   
    public void OnGUI()
    {
        //for picking up coins
        GUI.Label(new Rect(10, 10, 100, 20), "Score :" + points);

    }
   public void OnTriggerEnter(Collider collision)
    {
      if(collision.tag=="Magnet")
        {
            soundManager.instance.coinsource.PlayOneShot(soundManager.instance.magnetsound);
            isMagnet = true;
            Destroy(collision.gameObject);
        }
    }
}
