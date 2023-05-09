using _ConsoleTable;

namespace _VirtualTable {
    partial class VirtualTable {
        private List<ConsoleTable> _rows { get; set; } = new List<ConsoleTable>();

        public ConsoleTable this[int index] {
            get => _rows[index];
            set => _rows[index] = value;
        }

        public VirtualTable() { }
        public VirtualTable(List<ConsoleTable> rows) {
            _rows = rows;
        }
        public VirtualTable(VirtualTable other) {
            _rows = other._rows;
        }
    }
}