using System.Collections;

namespace NamesArrayListDemo.Lib.Interfaces
{

    public interface INamesArrayList
    {
        ArrayList GenerateNames(int numberOfNames = 10, int nameLength = 10);
    }

}