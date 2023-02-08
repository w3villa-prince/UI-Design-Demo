using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardArrayUpdate : MonoBehaviour
{
    public GameObject[] gameObjects;

    public CardArrayUpdate()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            ValueUpdate();
        }
    }

    private void ValueUpdate()
    {
    }

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
