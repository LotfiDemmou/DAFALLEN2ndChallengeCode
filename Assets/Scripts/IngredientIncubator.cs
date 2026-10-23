using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientIncubator : MonoBehaviour
{
    [SerializeField]private int[] Ingredientslist = new int[3];
    private int IngredientId = 0;

    private void Start()
    {
        GameEvents.current.onIngredientPutinDaCauldron += OnIngredientPut;
    }

    public void OnIngredientPut()
    {
       Debug.Log(IngredientId);
    }
}
