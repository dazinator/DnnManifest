using System;
using Csla;
using Csla.Server;
using Dazinate.Dnn.Manifest.Base;
using Dazinate.Dnn.Manifest.Package.Component.Container.ObjectFactory;

namespace Dazinate.Dnn.Manifest.Package.Component.Container
{
    [ObjectFactory(typeof(IContainerFileObjectFactory))]
    [Serializable]
    public class ContainerFile : BusinessBase<ContainerFile>, IContainerFile
    {
        public static readonly PropertyInfo<string> PathProperty = RegisterProperty<string>(c => c.Path);
        /// <summary>
        /// Target file folder. Relative to basePath.
        /// </summary>
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

        protected override void AddBusinessRules()
        {
            //todo: pretty sure sourcefilename is invalid for container files.
            base.AddBusinessRules();
        }


        public void Accept(IManifestVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}