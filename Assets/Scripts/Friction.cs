﻿using UnityEngine;

public class Friction : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    [SerializeField] private PhysicMaterial _default;
    [SerializeField] private PhysicMaterial _zero;
    [SerializeField] private Collider _leftFoot;
    [SerializeField] private Collider _rightFoot;

    private void SetDefaultFriction()
    {
        _rightFoot.material= _default;
        _leftFoot.material= _zero;
    }
    private void SetZeroFriction()
    {
        _rightFoot.material = _zero;
        _leftFoot.material = _default;
    }
    private void PlaySound()
    {
        _audio.Play();
    }
}
