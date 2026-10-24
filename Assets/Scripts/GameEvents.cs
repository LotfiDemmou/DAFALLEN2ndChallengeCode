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
    public event Action<string[]> onAllIngredientsinDaCauldron;
    public event Action<int> onPotionOutPut;

    public  void IngredientPutinDaCauldron(string IngredientName)
    {
        if(onIngredientPutinDaCauldron != null);
        {
            onIngredientPutinDaCauldron?.Invoke(IngredientName);
            Debug.Log("event1 activated");
        }
    }

        public  void AllIngredientsinDaCauldron(string[] Ingredients)
    {
        if(onAllIngredientsinDaCauldron != null);
        {
            onAllIngredientsinDaCauldron?.Invoke(Ingredients);
            Debug.Log("event2 activated");
        }
    }

            public  void PotionOutPut(int Potion)
    {
        if(onPotionOutPut != null);
        {
            onPotionOutPut?.Invoke(Potion);
            Debug.Log("event2 activated");
        }
    }
}
