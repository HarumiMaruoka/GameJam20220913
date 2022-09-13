using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0.01f, 0, 0);
        
        if (this.gameObject.transform.position.x < -10)
        {
            Destroy(this.gameObject);
        }
    }
}