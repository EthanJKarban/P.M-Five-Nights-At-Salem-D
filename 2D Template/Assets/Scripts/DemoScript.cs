using UnityEngine;
using UnityEngine.Windows.WebCam;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itemsToPickup;

    public void PickupItem(int id)
    {
       bool result = inventoryManager.AddItem(itemsToPickup[id]);
        if (result == true)
        {
            Debug.Log("Item Added");
        }
        else
        {
            Debug.Log("Stop hoarding you cow");
        }
    }
    public void GetSelectedItem()
    {
        Item receievedItem = inventoryManager.GetSelectedItem(false);
        if (receievedItem != null)
        {
         Debug.Log("Received item: " + receievedItem.name);
        }
        else
        {
            Debug.Log("Not Recieved");
        }

    }
    public void UseSelectedItem()
    {
        Item receievedItem = inventoryManager.GetSelectedItem(true);
        if (receievedItem != null)
        {
            Debug.Log("Use item: " + receievedItem.name);
        }
        else
        {
            Debug.Log("Not used");
        }

    }
}
