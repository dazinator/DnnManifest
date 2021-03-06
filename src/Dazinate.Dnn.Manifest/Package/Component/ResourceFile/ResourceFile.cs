using System;
using Csla;
using Csla.Server;
using Dazinate.Dnn.Manifest.Base;
using Dazinate.Dnn.Manifest.Package.Component.ResourceFile.ObjectFactory;

namespace Dazinate.Dnn.Manifest.Package.Component.ResourceFile
{
    [ObjectFactory(typeof(IResourceFileObjectFactory))]
    [Serializable]
    public class ResourceFile : BusinessBase<ResourceFile>, IResourceFile
    {
        public static readonly PropertyInfo<string> PathProperty = RegisterProperty<string>(c => c.Path);
        public string Path
        {
            get { return GetProperty(PathProperty); }
            set { SetProperty(PathProperty, value); }
        }

        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(c => c.Name);
        public string Name
        {
            get { return GetProperty(NameProperty); }
            set { SetProperty(NameProperty, value); }
        }

        public static readonly PropertyInfo<string> SourceFileNameProperty = RegisterProperty<string>(c => c.SourceFileName);
        public string SourceFileName
        {
            get { return GetProperty(SourceFileNameProperty); }
            set { SetProperty(SourceFileNameProperty, value); }
        }

        public void Accept(IManifestVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}