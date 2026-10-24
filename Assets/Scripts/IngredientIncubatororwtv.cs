using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientIncubator : MonoBehaviour
{
    [SerializeField]private string[] Ingredientslist = new string[3];
    [SerializeField] private GameObject CookArea;

    private int IngredientId =2;

    private void Start()
    { 
        
        IngredientId = 0;
        
        GameEvents.current.onIngredientPutinDaCauldron += OnIngredientPut;  

    }

    public void OnIngredientPut(string IngredientName)
    {
        if(IngredientId < 2)
        {
            Debug.Log(IngredientId);
            Ingredientslist[IngredientId] = IngredientName;
            IngredientId++;
            Debug.Log(Ingredientslist);
        }else
        {
            if(IngredientId == 2)
            {
                 Ingredientslist[IngredientId] = IngredientName;
                 IngredientId=0;
                 Debug.Log("event2 starts");
                 GameEvents.current.AllIngredientsinDaCauldron(Ingredientslist);
                 CookArea.SetActive(false);
            }
        }
    }
}
