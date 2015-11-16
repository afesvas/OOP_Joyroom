using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
    private List<GameObject> items;
    private bool open;

	// Use this for initialization
	void Start () {
	    items = new List<GameObject>();
        gameObject.GetComponent<SpriteRenderer>().color = Color.clear;
        open = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (open == true) Close();
            else Open();
        }
	}

    public void AddItem(GameObject item)
    {
        items.Add(item);
        item.GetComponent<Item>().SetInventory();
        item.transform.SetParent(transform);
        if (open == true)
        {
            Open();
        }
        else
        {
            item.SetActive(false);
        }
    }

    public void RemoveItem(GameObject item)
    {
        items.Remove(item);
        item.GetComponent<Item>().Destroy();
        if(open == true) Open();
    }

    public void Open()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        for (int i = 0; i < items.Count; i++)
        {
            items[i].SetActive(true);
            items[i].transform.localPosition = new Vector3(i+1, 0, -1);
        }
        open = true;
    }

    public void Close()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.clear;
        for (int i = 0; i < items.Count; i++)
        {
            items[i].SetActive(false);
        }
        open = false;
    }
}
