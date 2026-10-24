using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PotionMixer : MonoBehaviour
{
        private void Start()
    { 
        
        GameEvents.current.onAllIngredientsinDaCauldron += AllIngredientsIn;  

    }

    private void AllIngredientsIn(string[] Ingredients)
    {
       Debug.Log("methodcalled");
        var set = new HashSet<string>(Ingredients);
        Debug.Log(Ingredients);
        if (set.SetEquals(new[] { "Banana", "Eye", "Cat" }))
            Debug.Log("Potion1");
        else if (set.SetEquals(new[] { "Banana", "Eye", "Mushroom" }))
            Debug.Log("Potion2");
        else
            Debug.Log("No potion");

    }
}