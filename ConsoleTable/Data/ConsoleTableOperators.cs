using _VirtualTable;

namespace _ConsoleTable {
    partial class ConsoleTable {
        public static bool operator>(ConsoleTable left, ConsoleTable right)
            => left._items.Count > right._items.Count;

        public static bool operator<(ConsoleTable left, ConsoleTable right)
            => left._items.Count < right._items.Count;

        public static bool operator>=(ConsoleTable left, ConsoleTable right)
            => left._items.Count >= right._items.Count;

        public static bool operator<=(ConsoleTable left, ConsoleTable right)
            => left._items.Count <= right._items.Count;
            
        public static bool operator==(ConsoleTable left, ConsoleTable right)
            => right._items.Count == right._items.Count;

        public static bool operator!=(ConsoleTable left, ConsoleTable  right)
            => right._items.Count != left._items.Count;

        public static ConsoleTable operator+(ConsoleTable index, ITableItem item) {
            index._items.Add(item);

            return index;
        } 

        public static ConsoleTable operator-(ConsoleTable index, ITableItem item) {
            index.RemoveItem(item);

            return index;
        }
    }
}