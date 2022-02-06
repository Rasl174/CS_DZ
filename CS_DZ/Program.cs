using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPictures = 52;
            int picturesInLine = 3;
            int fullLines = allPictures / picturesInLine;
            int remainePictures = allPictures % picturesInLine;

            Console.WriteLine("Количество заполненых рядов- " + fullLines + " Оставшиеся картинки- " + remainePictures);
        }
    }
}
