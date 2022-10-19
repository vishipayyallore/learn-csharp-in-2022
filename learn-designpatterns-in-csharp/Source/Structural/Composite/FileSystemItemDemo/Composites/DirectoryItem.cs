using FileSystemItemDemo.Components;

namespace FileSystemItemDemo.Composites
{

    /// <summary>
    /// Composite
    /// </summary>
    public class DirectoryItem : FileSystemItem
    {
        private readonly long _size;
        private List<FileSystemItem> FileSystemItems { get; set; } = new List<FileSystemItem>();

        public DirectoryItem(string name, long size) : base(name)
        {
            _size = size;
        }

        public void Add(FileSystemItem itemToAdd)
        {
            FileSystemItems.Add(itemToAdd);
        }

        public void Remove(FileSystemItem itemToRemove)
        {
            FileSystemItems.Remove(itemToRemove);
        }

        public override long GetSize()
        {
            var treeSize = _size;

            foreach (var fileSystemItem in FileSystemItems)
            {
                treeSize += fileSystemItem.GetSize();
            }

            return treeSize;
        }
    }

}
