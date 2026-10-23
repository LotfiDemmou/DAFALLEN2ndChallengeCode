using UnityEngine;
using UnityEngine.InputSystem;

public class Ingredient : MonoBehaviour
{
    public string IngredientName;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private bool dragging;
    private Vector3 offset;

    private Vector3 MouseWorld()
    {
        Vector2 screenPos = Mouse.current.position.ReadValue();
        Vector3 world = Camera.main.ScreenToWorldPoint(screenPos);
        world.z = transform.position.z;
        return world;
    }

    private void OnMouseDown()
    {
        gameObject.layer = LayerMask.NameToLayer("TransportLayer");
        dragging = true;
        offset = transform.position - MouseWorld(); // no jump to cursor
    }

    private void Update()
    {
        if (!dragging) return;

        if (Mouse.current.leftButton.isPressed)
            transform.position = MouseWorld() + offset;
        else
        {
            dragging = false;
            gameObject.layer = LayerMask.NameToLayer("Default");
        }

    }
}