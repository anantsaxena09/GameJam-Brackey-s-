﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerManager : MonoBehaviour
{
    public static int numberofCoins;
    public static int heathOfPlayer;
    public TextMeshProUGUI coinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = " "+ numberofCoins;

        Debug.Log("Heath is incresed "+ heathOfPlayer);
        
    }
}
