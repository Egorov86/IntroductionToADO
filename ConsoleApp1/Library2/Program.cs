using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library2
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            //Library.Insert("Authors", "author_id,last_name,first_name", "10,'Mazin','Alexander'");
            Library.Insert
                (
                "Books",
                "book_id,book_title,book_size,publish_date,author",
                "6,'Vikings',950,'2010-10-10',10"
                );
            Library.Select("author_id,first_name,last_name", "Authors");
            Library.Select("book_title,publish_date,[Author]=first_name+' '+last_name",
                "Books,Authors",
                "author=author_id", 32
                );
        }
    }
}
