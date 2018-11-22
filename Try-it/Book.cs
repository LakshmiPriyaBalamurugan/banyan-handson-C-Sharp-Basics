using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRequirement_1
{
    class Book
    {
        private  string   _name;
        private  string   _authorName;
        private  string   _type;
        private  string   _catalogNo;
        private	DateTime  _publishedDate;
        private double _rating;

        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string AuthorName 
        {
            get
            {
                return _authorName;
            }
            set
            {
                _authorName = value;
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public string CatalogNo
        {
            get
            {
                return _catalogNo;
            }
            set
            {
                _catalogNo = value;
            }
        }
        public DateTime PublishedDate
        {
            get
            {
                return _publishedDate;
            }
            set
            {
                _publishedDate = value;
            }
        }
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                _rating = value;
            }
        }


        //public Book() { }
        public Book(string name, string authorName, string type, string catalogNo, DateTime publishedDate, double rating)
        {
            _name = name;
            _authorName = authorName;
            _type = type;
            _catalogNo = catalogNo;
            _publishedDate = publishedDate;
            _rating = rating;
        }

        public override string ToString()
        {
            return string.Format("Name: {0,-15}\nAuthor Name: {0, -15}\nType: {0,-15}\nCatelog No: {0,-15}\nPublish Date: {0,-15}\nRating: {0,-15}", _name,_authorName,_type,_catalogNo,_publishedDate,_rating);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            Book b = (Book)obj;
            return (this.Name == b.Name) && (this.AuthorName == b.AuthorName);
            
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
