using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public ScriptableItem[] weapons;
    public Text[] weaponsNames;
    public Image[] weaponsSprites;
    public Text[] weaponsCost;

    public ScriptableItem[] armors;
    public Text[] armorsNames;
    public Image[] armorsSprites;
    public Text[] armorsCost;

    void Awake()
    {
        instance = this;
    }

    public void AddWeapon(ScriptableItem item)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if (weapons[i] == null)
            {
                weapons[i] = item;
                weaponsNames[i].text = item.itemName;
                weaponsSprites[i].sprite = item.itemSprite;
                weaponsCost[i].text = item.itemPrice;

                return;
            }
        }
    }

    public void AddArmor(ScriptableItem item)
    {
        for (int i = 0; i < armors.Length; i++)
        {
            if (armors[i] == null)
            {
                armors[i] = item;
                armorsNames[i].text = item.itemName;
                armorsSprites[i].sprite = item.itemSprite;
                armorsCost[i].text = item.itemPrice;

                return;
            }
        }
    }
}