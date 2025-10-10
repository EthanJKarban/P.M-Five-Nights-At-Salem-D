using JetBrains.Annotations;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public Item[] startItems;

    public int maxStackedItems = 4;
    public InventorySlot[] inventorySlots;
    public GameObject inventoryItemPrefab;

    int selectedSlot = -1;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        ChangeSelectedSlot(0);
        foreach (var item in startItems)
        {
            AddItem(item);
        }
    }

    private void Update()
    {
        
        if (Input.inputString != null)
        {
            bool isNumber = int.TryParse(Input.inputString, out int number);
            if (isNumber && number > 0 && number < 8)
            {
                ChangeSelectedSlot(number - 1);
            }
        }

    }
    void ChangeSelectedSlot(int newValue)
    {
        if (selectedSlot >= 0)
        {
         inventorySlots[selectedSlot].Deselect();

        }

        inventorySlots[newValue].Select();
        selectedSlot = newValue;
    }
    public bool AddItem(Item item)
    {
        // This one stacks the item count if the item is already inside the inventory

        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot != null && itemInSlot.item == item && itemInSlot.count < maxStackedItems && itemInSlot.item.stackable == true)
            {
                itemInSlot.count++;
                itemInSlot.RefreshCount();
                return true;
            }

        }

        //Spawns in a new item if the item is not already in the inventory
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                return true;
            }

        }
        return false;
        void SpawnNewItem(Item item, InventorySlot slot)
        {
            GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);
            InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();
            inventoryItem.InitialiseItem(item);


        } }
        public Item GetSelectedItem(bool use)
    {
        InventorySlot slot = inventorySlots[selectedSlot];
        InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
        if (itemInSlot != null)
        {
            Item item = itemInSlot.item;
            if (use == true)
            {
                itemInSlot.count--;
                if (itemInSlot.count <= 0)
                {
                    Destroy(itemInSlot.gameObject);

                }
                else
                {
                    itemInSlot.RefreshCount();
                }
                
            }
            return item;
        }
        return null;
    }
}



/*This is put into update if you want to change the methods of inventory.
if (Input.GetKeyDown(KeyCode.Alpha1))
{
    ChangeSelectedSlot(0);
}
else if (Input.GetKeyDown(KeyCode.Alpha2))
{
    ChangeSelectedSlot(1);
}
else if (Input.GetKeyDown(KeyCode.Alpha3))
{
    ChangeSelectedSlot(2);
}
else if (Input.GetKeyDown(KeyCode.Alpha4))
{
    ChangeSelectedSlot(3);
}
else if (Input.GetKeyDown(KeyCode.Alpha5))
{
    ChangeSelectedSlot(4);
}
else if (Input.GetKeyDown(KeyCode.Alpha6))
{
    ChangeSelectedSlot(5);
}
else if (Input.GetKeyDown(KeyCode.Alpha7))
{
    ChangeSelectedSlot(6);
}
*/