using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyJoystick;
 
public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Joystick _joystick;

    private void Update()
    {
        //float xMovement = Input.GetAxis("Horizontal");
        //float zMovement = Input.GetAxis("Vertical");

        float xMovement = _joystick.Horizontal();
        float zMovement = _joystick.Vertical();

        transform.position += new Vector3(xMovement, 0f, zMovement) * _speed * Time.deltaTime;
    }
}
