using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour {
    public List<Item> items = new List<Item>();

    void Awake()
    {
        BuildDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item=> item.id == id);
    }

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }

    void BuildDatabase()
    {
        items = new List<Item>() {
            new Item(0, "Banana", "A delicious Banana.",
            new Dictionary<string, int> {
                { "Carb", 15 },
                { "Health", 10 }
            }),
            new Item(1, "Bean", "A small little bean.",
            new Dictionary<string, int> {
                { "Health", 3 }
            }),
            new Item(2, "Cherry", "A sweet cherry.",
            new Dictionary<string, int> {
                { "Carb", 5 },
                { "Health", 20}
            }),
            new Item(3, "Radish", "A radish. Core ingredient for making food.",
            new Dictionary<string, int> {
                { "Carb", 5 },
                { "Health", 20}
            })
        };
    }
}
