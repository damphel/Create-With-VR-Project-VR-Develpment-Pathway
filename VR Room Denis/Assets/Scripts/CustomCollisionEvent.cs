using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomCollisionEvent : MonoBehaviour
{
    [SerializeField] UnityEvent DoOnCollision;

    private void OnCollisionEnter(Collision collision)
    {
        DoOnCollision.Invoke();
    }
}
