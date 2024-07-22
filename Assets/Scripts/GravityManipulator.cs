using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManipulator : MonoBehaviour
{
    public Transform hologram;
    private Vector3 gravityDirection = Vector3.down;
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gravityDirection = Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            gravityDirection = Vector3.back;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gravityDirection = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gravityDirection = Vector3.right;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            hologram.gameObject.SetActive(true);
            hologram.forward = gravityDirection;
        }
        else
        {
            hologram.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Physics.gravity = gravityDirection * 9.81f;
        }
    }
}