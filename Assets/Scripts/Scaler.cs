using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;

    private void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime * _growthSpeed;
    }
}