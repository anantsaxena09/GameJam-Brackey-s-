﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
   
  private void OnTriggerEnter2D(Collider2D other) {
    
    if(other.transform.tag == "Player")
        {
            PlayerManager.numberofCoins++;
            Destroy(gameObject);
        }
  }
}
