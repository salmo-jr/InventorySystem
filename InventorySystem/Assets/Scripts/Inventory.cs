using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> characterItems = new List<Item>();
    public ItemDatabase itemDatabase;
    public UIInventory inventoryUI;

    private void Start()
    {
        GiveItem("Diamond Sword");
        GiveItem(1);
        GiveItem(2);
        //RemoveItem(1);
    }

    public void GiveItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);
        GiveItem(itemToAdd);
    }

    public void GiveItem(string name)
    {
        Item itemToAdd = itemDatabase.GetItem(name);
        GiveItem(itemToAdd);
    }

    public void GiveItem(Item item)
    {
        characterItems.Add(item);
        inventoryUI.AddNewItem(item);
        Debug.Log("Added item: " + item.title);
    }

    public Item CheckForItem(int id)
    {
        return characterItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)
    {
        Item item = CheckForItem(id);
        if (item != null)
        {
            characterItems.Remove(item);
            inventoryUI.RemoveItem(item);
            Debug.Log("Item removed: " + item.title);
        }
    }
}
