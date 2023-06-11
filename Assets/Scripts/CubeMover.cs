using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private Rigidbody _cube;
    private bool _moveDirection = true;

    private void Update()
    {
        MoveCube();
    }

    private void MoveCube()
    {
        if (_moveDirection)
        {
            
                _cube.AddForce(-1f,0f,0f,ForceMode.Impulse);
            
            
            _moveDirection = false;
        }
        else
        {
            
                _cube.AddForce(-1f,0f,0f,ForceMode.Impulse);
            
            _moveDirection = true;
        }

        
    }
}
