using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action<string> onIngredientPutinDaCauldron;
    public  void IngredientPutinDaCauldron(string IngredientName)
    {
        if(onIngredientPutinDaCauldron != null);
        {
            onIngredientPutinDaCauldron?.Invoke(IngredientName);
            Debug.Log("event activated");
        }
    }

}
