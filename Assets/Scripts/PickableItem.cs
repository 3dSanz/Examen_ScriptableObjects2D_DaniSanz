using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public ScriptableItem item;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Start()
    {
        spriteRenderer.sprite = item.itemSprite;
    }

    void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            if(gameObject.layer == 6)
            {
                InventoryManager.instance.AddWeapon(item);
            } else if(gameObject.layer == 7)
            {
                InventoryManager.instance.AddArmor(item);
            }
        }
        Destroy(this.gameObject);
    }
}
