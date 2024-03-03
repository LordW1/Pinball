using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip1 : MonoBehaviour
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
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            _rb.MoveRotation(10);
            over = true;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            _rb.MoveRotation(-5);
            over = false;
        }

        
    }
}

