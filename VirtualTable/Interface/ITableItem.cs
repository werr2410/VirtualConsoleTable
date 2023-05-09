namespace _VirtualTable {
    interface ITableItem {
        string Value { get; set; }
        
        int LenghtItem => Value.Length;
    }
}