using System.Xml.XPath;
using Dazinate.Dnn.Manifest.Ioc;
using Dazinate.Dnn.Manifest.Model.Manifest;
using Dazinate.Dnn.Manifest.Model.ResourceFilesList.ObjectFactory;
using Dazinate.Dnn.Manifest.Utils;

namespace Dazinate.Dnn.Manifest.Model.Component.SubObjectFactory
{
    public class ResourceFileComponentSubObjectFactory : BaseObjectFactory, IComponentSubObjectFactory
    {

        private readonly IResourceFilesListObjectFactory _filesListObjectFactory;

        public ResourceFileComponentSubObjectFactory(IObjectActivator activator, IResourceFilesListObjectFactory filesListObjectFactory) : base(activator)
        {
            _filesListObjectFactory = filesListObjectFactory;
        }

        public string ComponentTypeName { get { return "ResourceFile"; } }

        public IComponent Fetch(XPathNavigator nav)
        {
            var component = CreateInstance<ResourceFileComponent>();

            var filesNode = nav.SelectSingleNode("resourceFiles");
            if (filesNode == null)
            {
                throw new InvalidManifestFormatException();
            }

            var basePath = XmlUtils.ReadElement(filesNode, "basePath");
            LoadProperty(component, ResourceFileComponent.BasePathProperty, basePath);

            var filesList = _filesListObjectFactory.Fetch(nav);
            LoadProperty(component, ResourceFileComponent.FilesProperty, filesList);

            return component;

        }


    }
}