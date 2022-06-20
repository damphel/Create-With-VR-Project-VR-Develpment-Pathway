using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAnim : MonoBehaviour
{
    [SerializeField] float speed = 25f;

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);    
    }
}
