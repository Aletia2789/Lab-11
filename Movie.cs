using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11

{
    public class Movie
    {
        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        private string _category;
        private string _title;

       public string GetCategory() 
        {
            return _category;
        } 

        public string GetTitle() 
        {
            return _title;
        }
    }
   
}