namespace System.Windows.Controls
{
    public static class ItemsControlExtensions
    {
        //
        // Summary:
        //     Determines if the specified item is (or is eligible to be) its own container.
        //
        // Parameters:
        //   item:
        //     The item to check.
        //
        // Returns:
        //     /// true if the item is (or is eligible to be) its own container; otherwise,
        //     false.
        public static bool IsItemItsOwnContainer(ItemsControl @this, object item)
        {
            return IsItemItsOwnContainerOverride(item);
        }

        //
        // Summary:
        //     Determines if the specified item is (or is eligible to be) its own container.
        //
        // Parameters:
        //   item:
        //     The item to check.
        //
        // Returns:
        //     /// true if the item is (or is eligible to be) its own container; otherwise,
        //     false.
        private static bool IsItemItsOwnContainerOverride(object item)
        {
            return item is UIElement;
        }
    }
}
