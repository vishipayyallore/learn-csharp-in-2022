using FileSystemItemDemo.Components;

namespace FileSystemItemDemo.Composites
{

    /// <summary>
    /// Composite
    /// </summary>
    public class Directory : FileSystemItem
    {
        private long _size;
        private List<FileSystemItem> _fileSystemItems { get; set; } = new List<FileSystemItem>();

        public Directory(string name, long size) : base(name)
        {
            _size = size;
        }

        public void Add(FileSystemItem itemToAdd)
        {
            _fileSystemItems.Add(itemToAdd);
        }

        public void Remove(FileSystemItem itemToRemove)
        {
            _fileSystemItems.Remove(itemToRemove);
        }

        public override long GetSize()
        {
            var treeSize = _size;
            foreach (var fileSystemItem in _fileSystemItems)
            {
                treeSize += fileSystemItem.GetSize();
            }
            return treeSize;
        }
    }

}
