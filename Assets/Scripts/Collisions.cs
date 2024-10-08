using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public GameObject winpanel1;
    public GameObject winpanel2;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Enemy")
        {
             GameManager.health--;
             if(GameManager.health <=0)
             {
                 winpanel2.SetActive(true);
             }
        }

        if(collision.transform.tag == "Finish")
        {
            winpanel1.SetActive(true);
            Time.timeScale = 0f;
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
