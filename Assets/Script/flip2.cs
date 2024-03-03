using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip2 : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D _rb;
    private bool over=false;
 

    void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            _rb.MoveRotation(-10);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            _rb.MoveRotation(5);
        }

        
    }
}
