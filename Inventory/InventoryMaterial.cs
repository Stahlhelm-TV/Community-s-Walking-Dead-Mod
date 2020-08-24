﻿using CWDM.Enums;
using System;

namespace CWDM.Inventory
{
    [Serializable]
    public class InventoryMaterial : InventoryItem
    {
        public InventoryMaterial(string name, string description, int amount, int maxAmount, LootType[] lootTypes)
            : base(name, description, amount, maxAmount, lootTypes)
        {
            Name = name;
            Description = description;
            Amount = amount;
            MaxAmount = maxAmount;
            SetLootTypes(lootTypes);
        }
    }
}