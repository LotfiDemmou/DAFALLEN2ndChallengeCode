using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientIncubator : MonoBehaviour
{
    [SerializeField]private string[] Ingredientslist = new string[3];
    private int IngredientId =2;

    private void Start()
    { 
        
        IngredientId = 0;
        
        GameEvents.current.onIngredientPutinDaCauldron += OnIngredientPut;  

    }

    public void OnIngredientPut(string IngredientName)
    {
        if(IngredientId < Ingredientslist.Length)
        {
            Debug.Log(IngredientId);
            Ingredientslist[IngredientId] = IngredientName;
            IngredientId++;
            Debug.Log(Ingredientslist);
        } 
    }
}
