using System.Xml.XPath;
using Dazinate.Dnn.Manifest.Base;
using Dazinate.Dnn.Manifest.Exceptions;
using Dazinate.Dnn.Manifest.Ioc;
using Dazinate.Dnn.Manifest.Package.Component.ObjectFactory;
using Dazinate.Dnn.Manifest.Utils;

namespace Dazinate.Dnn.Manifest.Package.Component.SkinObject.ObjectFactory
{
    public class SkinObjectComponentSubObjectFactory : BaseObjectFactory, IComponentSubObjectFactory
    {
        public SkinObjectComponentSubObjectFactory(IObjectActivator activator) : base(activator)
        {

        }

        public ComponentType ComponentType
        {
            get
            {
                return ComponentType.SkinObject;
            }
        }


        public IComponent Create(ComponentType componentType)
        {
            var component = CreateInstance<SkinObjectComponent>();
            MarkAsChild(component);
            MarkNew(component);
            return component;
        }

        public IComponent Fetch(XPathNavigator nav)
        {
            var component = CreateInstance<SkinObjectComponent>();
            var node = nav.SelectSingleNode("moduleControl");
            if (node == null)
            {
                throw new InvalidManifestFormatException();
            }

            var controlKey = XmlUtils.ReadElement(node, "controlKey");
            LoadProperty(component, SkinObjectComponent.ControlKeyProperty, controlKey);

            var controlSrc = XmlUtils.ReadElement(node, "controlSrc");
            LoadProperty(component, SkinObjectComponent.ControlSourceProperty, controlSrc);

            var supportsPartialRendering = XmlUtils.ReadElement(node, "supportsPartialRendering");
            var boolValue = bool.Parse(supportsPartialRendering);
            LoadProperty(component, SkinObjectComponent.SupportsPartialRenderingProperty, boolValue);

            return component;
        }


    }
}