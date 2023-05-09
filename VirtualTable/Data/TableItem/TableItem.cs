namespace _ConsoleTable {
    partial class TableItem : ITableItem {
        public string Value { get; set; } = "";
        
        public TableItem() {}
        public TableItem(string value) => Value = value;

        public override string ToString() => Value;

        public override bool Equals(object? obj) {
            return obj is TableItem item &&
                   Value == item.Value;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Value);
        }

        // operator


        public static bool operator>(TableItem left, TableItem right)
            => left.Value.Length > right.Value.Length;
        public static bool operator<(TableItem left, TableItem right)
            => left.Value.Length < right.Value.Length;
        public static bool operator>=(TableItem left, TableItem right)
            => !(left < right);
        public static bool operator<=(TableItem left, TableItem right)
            => left < right || left == right;
        public static bool operator==(TableItem left, TableItem right)
            => left.Value.Length == right.Value.Length;
        public static bool operator!=(TableItem left, TableItem right)
            => !(left == right);
        public static TableItem operator+(TableItem left, string right) {
            left.Value += right;

            return left;
        }
        public static TableItem operator*(TableItem left, int multiply) {
            var res = new System.Text.StringBuilder();

            for(int i = 0; i < multiply; i++) 
                res.Append(left.Value);

            left.Value = res.ToString();

            return left;
        }
        
        public static explicit operator TableItem(string value)
            => new TableItem(value);

        public static implicit operator string(TableItem item)
            => item.Value;
    }
}