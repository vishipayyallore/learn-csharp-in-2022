﻿namespace FileSystemItemDemo.Components
{

    /// <summary>
    /// Component
    /// </summary>
    public abstract class FileSystemItem
    {
        public string Name { get; set; }

        public abstract long GetSize();

        public FileSystemItem(string name)
        {
            Name = name;
        }
    }

}
