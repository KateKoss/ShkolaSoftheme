using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_1
{
    public class Photo
    {
        string photo { get; }
        public Photo(string photo)
        {
            this.photo = photo;
        }
        public string GetPhoto()
        {
            return photo;
        }
    }
}
