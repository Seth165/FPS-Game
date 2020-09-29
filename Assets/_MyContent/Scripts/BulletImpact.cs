using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletImpact : MonoBehaviour
{
    // checks if bullet has hit an object to destroy it
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "something")
        {
            Destroy(gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
