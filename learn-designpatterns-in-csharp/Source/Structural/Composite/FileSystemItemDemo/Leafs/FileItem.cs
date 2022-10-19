using FileSystemItemDemo.Components;

namespace FileSystemItemDemo.Leafs
{

    /// <summary>
    /// Leaf
    /// </summary>
    public class FileItem : FileSystemItem
    {
        private long _size;
        public FileItem(string name, long size) : base(name)
        {
            _size = size;
        }

        public override long GetSize()
        {
            return _size;
        }
    }

}
