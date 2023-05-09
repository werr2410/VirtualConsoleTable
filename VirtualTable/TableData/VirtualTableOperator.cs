namespace _VirtualTable {
    partial class VirtualTable {
        public static bool operator>(VirtualTable right, VirtualTable left)
            => right.Lenght > left.Lenght;
        public static bool operator<(VirtualTable right, VirtualTable left)
            => right.Lenght < left.Lenght;
        public static bool operator>=(VirtualTable right, VirtualTable left)
            => right.Lenght >= left.Lenght;
        public static bool operator<=(VirtualTable right, VirtualTable left)
            => right.Lenght <= left.Lenght;
        public static bool operator==(VirtualTable right, VirtualTable left)
            => right._rows == left._rows;
        public static bool operator!=(VirtualTable right, VirtualTable left)
            => right._rows != left._rows;
        public static explicit operator VirtualTable(List<_ConsoleTable.ConsoleTable> value)
            => new VirtualTable(value);
        public static implicit operator List<_ConsoleTable.ConsoleTable>(VirtualTable item)
            => item._rows;

        public override bool Equals(object? obj) {
            return obj is VirtualTable table &&
                   ((VirtualTable)obj)._rows == _rows;
        }

        public override int GetHashCode() 
            => HashCode.Combine(_rows, Lenght);   
    }
}