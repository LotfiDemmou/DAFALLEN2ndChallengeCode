using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PotionMixer : MonoBehaviour
{
    
    public int Potion;
    
    
        private void Start()
    { 
        GameEvents.current.onAllIngredientsinDaCauldron += AllIngredientsIn;  
    }

    private void AllIngredientsIn(string[] Ingredients)
    {
  
        var set = new HashSet<string>(Ingredients);

             if (set.SetEquals(new[] { "Banana", "Eye", "Cat" }))
             Potion = 1;
             else if (set.SetEquals(new[] { "Banana", "Eye", "Mushroom" }))
             Potion = 2;
             else if (set.SetEquals(new[] { "Banana", "Bouzlouf", "Mushroom" }))
             Potion = 3;
             else if (set.SetEquals(new[] { "Bouzlouf", "Eye", "Mushroom" }))
             Potion = 4;
             else if (set.SetEquals(new[] { "Banana", "Eye", "Bouzlouf" }))
             Potion = 5;
             else if (set.SetEquals(new[] { "cat", "Eye", "Mushroom" }))
             Potion = 6;

        else
            Potion = 0;
        Debug.Log(Potion);
    }
}