using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _movementSpeed = 0.5f;

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _movementSpeed);
    }
}