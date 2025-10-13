using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using JetBrains.Annotations;
using UnityEngine.Rendering.Universal;

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
        if (GameObject.FindGameObjectWithTag("Player").TryGetComponent(out Light2D light))
        {
            InventoryItem inventoryItem = GetComponentInChildren<InventoryItem>();

            light.intensity = inventoryItem.item.lightIntensity;
            light.pointLightOuterRadius = inventoryItem.item.lightRadius;
            light.color = inventoryItem.item.lightColor;
            light.lightType = inventoryItem.item.light;
        }

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
