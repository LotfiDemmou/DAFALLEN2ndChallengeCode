using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookArea : MonoBehaviour
{
     private void OnTriggerEnter(Collider other)
     {
        GameEvents.current.IngredientPutinDaCauldron();
     }
}
