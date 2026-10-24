using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] private Image spriteRenderer;
    [SerializeField] private Sprite[] sprites;   

    private void Start()
    { 
        GameEvents.current.onPotionOutPut += PotionOut;  
    }

    private void PotionOut(int Potion)
    {
        spriteRenderer.sprite = sprites[Potion];
    }
}
