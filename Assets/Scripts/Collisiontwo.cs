using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiontwo : MonoBehaviour
{
    public GameObject winpanel2;
    public GameObject winpanel1;
      private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            HealthManager.health--;
            if(HealthManager.health <=0)
            {
                winpanel1.SetActive(true);
            }
        }

        if(collision.transform.tag == "Finish")
        {
            winpanel2.SetActive(true);
            Time.timeScale = 0f;
            
        }
    }
}
