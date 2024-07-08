using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyboardKey : MonoBehaviour
{
    [Header("Key Settings")]
    public KeyCode TargetKey;

    [Header("Event Settings")]
    public UnityEvent OnKeyDown;
    public UnityEvent OnKeyPress;
    public UnityEvent OnKeyUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(TargetKey))
        {
            Debug.Log("Key Down!");
            OnKeyDown.Invoke();
        }
        if (Input.GetKey(TargetKey))
        {
            Debug.Log("Key Pressed!");
            OnKeyPress.Invoke();
        }
        if (Input.GetKeyUp(TargetKey))
        {
            Debug.Log("Key Up!");
            OnKeyUp.Invoke();
        }
    }
}

