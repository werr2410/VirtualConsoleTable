using _VirtualTable;

namespace _ConsoleTable {
    partial class ConsoleTable {

        public char Border { get; set; } = '#';
        public bool Space { get; set; } = true;

        private char SpaceChar => ' ';
        
        private uint MaxLenghtItem {
            get {
                int maxItem = 0;

                foreach(ITableItem item in _items) {
                    if(item.LenghtItem > maxItem)
                        maxItem = item.LenghtItem;
                }

                return (uint)maxItem;
            }
        }

        private uint CountLines {
            get {
                return _items.Count == 0 ? 0 : (uint)_items.Count * 2 + 1;
            }
        }
        private uint LenghtTable {
            get {
                uint border = 2;
                uint spaces = Space ? (uint)2 : (uint)0;
                uint LenghtItem = MaxLenghtItem;

                return border + spaces + LenghtItem;
            }
        }

        private string FullString {
            get {
                string res = "";

                for(int i = 0; i < LenghtTable; i++)
                    res += Border;

                return res;
            }
        }


        private string GetSpacesForLine(string Value) {
            string res = "";

            for(int i = Value.Length; i < MaxLenghtItem; i++)
                res += SpaceChar;

            return res;
        }

        private void SpaceAt(ref string append) {
            if(Space) append += SpaceChar;
        }

        public string OnceTable() {
            var builder = new System.Text.StringBuilder();
            string append = "";
            int iterator = 0;

            for(int i = 0; i < CountLines; i++) {
                append = "";

                if(i % 2 == 0) {
                    append = FullString;
                } else {
                    append += Border;                                       // |#|
                    SpaceAt(ref append);                                    // |# |

                    append += _items[iterator].Value;                       // |# some_value|
                    append += GetSpacesForLine(_items[iterator].Value);     // Add space for table be once size

                    SpaceAt(ref append);                                    // |# some_value |
                    append += Border;                                       // |# some_value #|
                    
                    iterator++;
                }

                builder.AppendLine(append);
            }
            
            return builder.ToString();
        }
    }
}