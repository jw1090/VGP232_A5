using System;
using System.Collections.Generic;

namespace Assignment5
{
    public class Inventory
    {
        // The List items consist of the item and the quantity
        private List<Item> items;

        // The available slots to add item, once it's 0, you cannot add any more items.
        private int availableSlots;
        public int AvailableSlots { get => availableSlots; }

        // The max available slots which is set only in the constructor.
        private int maxSlots;
        public int MaxSlots { get => maxSlots; }

        public Inventory(int slots)
        {
            availableSlots = maxSlots;
            maxSlots = slots;
        }

        /// <summary>
        /// Removes all the items, and restore the original number of slots.
        /// </summary>
        public void Reset()
        {
            items.Clear();
            availableSlots = maxSlots;
        }

        /// <summary>
        /// Removes the item from the items dictionary if the count is 1 otherwise decrease the quantity.
        /// </summary>
        /// <param name="name">The item name</param>
        /// <param name="found">The item if found</param>
        /// <returns>True if you find the item, and false if it does not exist.</returns>
        bool TakeItem(string name, out Item found)
        {
            found = null;

            return false;
        }

        /// <summary>
        /// Checks if there is space for a unique item
        /// </summary>
        /// <param name="newItem"></param>
        /// <returns></returns>
        bool AddItem(Item newItem)
        {
            // Add it in the items dictionary and increment it the number if it already exist
            // Reduce the slot once it's been added.
            // returns false if the inventory is full

            Item itemInInventory = ItemSearch(newItem); // Potential reference to the item in inventory. Returns null if not found.
            if (itemInInventory == null) // Item is not in inventory.
            {
                if (availableSlots == 0)
                {
                    Console.WriteLine($"No slots avaialable.");
                    return false;
                }

                items.Add(newItem);
                --availableSlots;
                return true;
            }
            else // Item found so increase it's amount by how many were picked up.
            {
                itemInInventory.Amount += newItem.Amount;
                return true;
            }
        }

        private Item ItemSearch(Item itemToFind)
        {
            foreach (Item item in items)
            {
                if (itemToFind.Name == item.Name)
                {
                    return item;
                }
            }

            return null;
        }

        /// <summary>
        /// Iterates through the dictionary and create a list of all the items.
        /// </summary>
        /// <returns></returns>
        List<Item> ListAllItems()
        {
            // use a foreach loop to iterate through the key value pairs and duplicate the item base on the quantity.
            throw new NotImplementedException();
        }
    }
}