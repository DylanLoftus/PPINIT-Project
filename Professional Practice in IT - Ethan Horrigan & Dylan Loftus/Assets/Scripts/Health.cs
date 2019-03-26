﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public static int keysCollected;
    public int keysNeeded;

    public Image[] keys;
    public Sprite fullKey;
    public Sprite emptyKey;


    public static int health;
    public int healthLeft;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            if(i < keysCollected)
            {
                keys[i].sprite = fullKey;
            }
            else
            {
                keys[i].sprite = emptyKey;
            }

            if(i < keysNeeded)
            {
                keys[i].enabled = true;
            } else
            {
                keys[i].enabled = false;
            }
        }


    }
}