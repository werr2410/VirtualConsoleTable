namespace _ConsoleTable {
    partial class TableItem : ITableItem {
        public TableItem this[string value] {
            get => new TableItem(value);
        }
    }
}
