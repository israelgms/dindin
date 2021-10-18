using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;

namespace Curso
{
    internal class PsysicalFileProvider : IFileProvider
    {
        private string v;

        public PsysicalFileProvider(string v)
        {
            this.v = v;
        }

        public IDirectoryContents GetDirectoryContents(string subpath)
        {
            throw new System.NotImplementedException();
        }

        public IFileInfo GetFileInfo(string subpath)
        {
            throw new System.NotImplementedException();
        }

        public IChangeToken Watch(string filter)
        {
            throw new System.NotImplementedException();
        }
    }
}