﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string title)
    {
        return items.Find(item => item.title == title);
    }

    void BuildDatabase()
    {
        items = new List<Item>() {
            new Item(0, "Diamond Sword", "A sword made with diamond.",
                new Dictionary<string, int>
                {
                    {"Power", 15},
                    {"Defence", 10}
                }),
            new Item(1, "Diamond Ore", "A beautiful diamond",
                new Dictionary<string, int>
                {
                    {"Value", 444}
                }),
            new Item(2, "Silver Pick", "A very C# pick",
                new Dictionary<string, int>
                {
                    {"Power", 5},
                    {"Mining", 333}
                })
        };
    }
}
