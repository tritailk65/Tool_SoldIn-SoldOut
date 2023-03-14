using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tool_SoldIn_SoldOut.DTO
{
    class ComboboxValueDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ComboboxValueDTO(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
