using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLinQ
{
    class Categories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return string.Format("ProductId = {0}, ProductName = {1}",
                CategoryId, CategoryName);
        }
    }
}
