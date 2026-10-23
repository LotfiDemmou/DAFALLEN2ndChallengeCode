using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookArea : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
   {
      Ingredient ingredient = other.GetComponent<Ingredient>();
      if (ingredient == null) return;

      GameEvents.current.IngredientPutinDaCauldron(ingredient.IngredientName);
      Destroy(ingredient.gameObject);
      Debug.Log("Ingredient In da Cauldron");

   }
}
