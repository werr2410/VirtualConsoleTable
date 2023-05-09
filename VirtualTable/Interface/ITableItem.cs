namespace _ConsoleTable {
    interface ITableItem {
        string Value { get; set; }
        
        int LenghtItem => Value.Length;
    }
}