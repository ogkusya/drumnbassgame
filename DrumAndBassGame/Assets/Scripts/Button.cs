using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [Header("Changable parameters")]
    [SerializeField] private KeyCode _keyCode;

    [Range(0, 100)] [SerializeField] private int _percentOfPressed;

    private Vector3 _lastPosition;

    void Start()
    {
        _lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_keyCode))
        {
            transform.position += Vector3.down * _percentOfPressed / 1000;
        }

        if (Input.GetKeyUp(_keyCode))
        {
            transform.position += Vector3.up * _percentOfPressed / 1000;
        }
    }
}
