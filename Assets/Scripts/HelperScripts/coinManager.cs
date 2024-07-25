using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinManager : MonoBehaviour
{
   
   

    // Update is called once per frame
    //void Update()
    //{
    //    transform.Rotate(90 * Time.deltaTime, 0, 0);
    //}
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {//add 1 to points
            other.GetComponent<playerMovement>().points++;
            //destroy coins
            Destroy(gameObject);
            soundManager.instance.coinsource.PlayOneShot(soundManager.instance.coinSound);

        }
    }
   
}
