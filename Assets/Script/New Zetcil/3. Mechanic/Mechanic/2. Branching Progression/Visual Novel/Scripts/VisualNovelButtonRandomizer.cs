﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualNovelButtonRandomizer : MonoBehaviour
{
    [Header("Container Object")]
    public List<GameObject> Container;

    [Header("Button Settings")]
    public List<GameObject> TargetButton;

    // Start is called before the first frame update
    void Start()
    {
        Shuffle(Container);
        Replacement();
    }

    void Shuffle(List<GameObject> a)
    {
        // Loop array
        for (int i = a.Count - 1; i > 0; i--)
        {
            // Randomize a number between 0 and i (so that the range decreases each time)
            int rnd = UnityEngine.Random.Range(0, i);

            // Save the value of the current i, otherwise it'll overwrite when we swap the values
            GameObject temp = a[i];

            // Swap the new and old values
            a[i] = a[rnd];
            a[rnd] = temp;
        }
    }

    void Replacement()
    {
        for (int i = 0; i < Container.Count; i++)
        {
            TargetButton[i].transform.localScale = Container[i].transform.localScale;
            TargetButton[i].transform.position = Container[i].transform.position;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
