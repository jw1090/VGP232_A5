namespace Assignment5
{
    public enum ItemGroup { Consumable, Key, Equipment };
    public class Item
    {
        public string Name { get; set; }
        public int ContextAmount { get; set; }
        public ItemGroup Group { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="contextAmount"></param>
        /// <param name="group"></param>
        public Item(string name, int contextAmount, ItemGroup group)
        {
            Name = name;
            ContextAmount = contextAmount;
            Group = group;
        }

        public override string ToString()
        {
            // TODO: display the output like this Axe
            return base.ToString();
        }
    }
}
