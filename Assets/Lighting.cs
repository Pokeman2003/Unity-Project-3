using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    public float Speed = 1f; //Public speed!
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Speed controls.
        //Placed early here because of the cancel.
        if (Input.GetKey(KeyCode.Equals))
        {
            Speed += 1f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Minus))
        {
            Speed -= 1f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            Speed = 1f;
        }

        if (Input.GetKey(KeyCode.Space)) // Holding space activates this.
        {
            if (Input.GetKey(KeyCode.X)) // And you've terminated it. Great.
            {
                return;
            }
            //Left Right
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(-50f, 0f, 0f, Space.Self); // Introduced to fix weird rotation.
                transform.Rotate(0f, 45f * Time.deltaTime * Speed, 0f, Space.Self);
                transform.Rotate(50f, 0f, 0f, Space.Self);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(-50f, 0f, 0f, Space.Self);
                transform.Rotate(0f, -45f * Time.deltaTime * Speed, 0f, Space.Self);
                transform.Rotate(50f, 0f, 0f, Space.Self);
            }
            //Rotational Reset
            if (Input.GetKey(KeyCode.KeypadPlus) || Input.GetKey(KeyCode.Keypad0))
            {
                transform.rotation = Quaternion.identity;
                transform.Rotate(50f, 0f, 0f, Space.Self); //Only kept Keypad0 for ease of use.
            }
        }
    }
}
