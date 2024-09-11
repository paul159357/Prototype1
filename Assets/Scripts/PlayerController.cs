using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //SerializeField = private 접근 수준 유지하면서 인스펙터에 표시, Range = 슬라이더 표기
    [SerializeField][Range(0, 20f)] private float _speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward*_speed*Time.deltaTime);
    }
}
