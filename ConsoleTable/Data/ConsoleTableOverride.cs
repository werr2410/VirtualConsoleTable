using _VirtualTable;

namespace _ConsoleTable {
    partial class ConsoleTable {
        public override bool Equals(object? obj) {
            return obj is ConsoleTable table &&
                   EqualityComparer<List<ITableItem>>.Default.Equals(_items, table._items) &&
                   Border == table.Border &&
                   Space == table.Space;
        }

        public override int GetHashCode() {
            return HashCode.Combine(_items, Border, Space);
        }

        public override string ToString() => OnceTable();
    }
}