﻿namespace NamesGenerator.Lib.Interfaces
{

    public interface IGenerateNames
    {
        string[] GetNames(int nameLength = 10, int numberOfNames = 10);
    }

}
