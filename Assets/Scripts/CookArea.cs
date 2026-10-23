using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookArea : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
   {
      GameEvents.current.IngredientPutinDaCauldron();
      Debug.Log("Ingredient In da Cauldron");
   }
}
