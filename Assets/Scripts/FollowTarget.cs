using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] private Vector3 _offset;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _target.position + _offset;
    }
}
