﻿namespace DesignPattern.Comosite.DAL
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int UpperCategoryID { get; set; }
        public List<Product> Products { get; set; }
    }
}
