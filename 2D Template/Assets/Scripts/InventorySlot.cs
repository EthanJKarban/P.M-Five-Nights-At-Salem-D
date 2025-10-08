using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using JetBrains.Annotations;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    
    private Image image;
    public Color selectedColor, notSelectedColor;

    private void Awake()
    {
        image = GetComponent<Image>();
        Deselect();
    }
    public void Select()
    {
        image ??= GetComponent<Image>();

        image.color = selectedColor;
    }
    public void Deselect()
    {
        image.color = notSelectedColor;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            InventoryItem inventoryItem = eventData.pointerDrag.GetComponent<InventoryItem>();
            inventoryItem.parentAfterDrag = transform;
        }
    }
}
