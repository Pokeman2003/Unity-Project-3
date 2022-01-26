using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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

        //Cancel control if Alt or space is held down
        if ((Input.GetKey(KeyCode.Z)) || (Input.GetKey(KeyCode.Space)))
        {
            return;
        }
            //Up Down Left (Down) Right
            if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * 8f * Speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * 8f * Speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * 8f * Speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * 8f * Speed;
        }
        //Z+ [Z+] Z- [Z-]
        if (Input.GetKey(KeyCode.RightShift))
        {
            transform.position += Vector3.up * Time.deltaTime * 4f * Speed;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += Vector3.up * Time.deltaTime * 4f * Speed;
        }
        if (Input.GetKey(KeyCode.RightControl))
        {
            transform.position += Vector3.down * Time.deltaTime * 4f * Speed;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.position += Vector3.down * Time.deltaTime * 4f * Speed;
        }
        //Positional reset.
        if (Input.GetKey(KeyCode.KeypadMinus) || Input.GetKey(KeyCode.Keypad0))
        {
            transform.position = new Vector3(0f, 0f, 0f);
        }
        //Rotate Controls
        //Left Right
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, 45f * Time.deltaTime * Speed, 0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, -45f * Time.deltaTime * Speed, 0f, Space.Self);
        }
        //Up Down
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(45f * Time.deltaTime * Speed, 0f, 0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(-45f * Time.deltaTime * Speed, 0f, 0f, Space.Self);
        }
        //Rotational Reset
        if (Input.GetKey(KeyCode.KeypadPlus) || Input.GetKey(KeyCode.Keypad0))
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
