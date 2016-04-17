using System;
using Csla;
using Csla.Server;
using Dazinate.Dnn.Manifest.Model.Script;
using Dazinate.Dnn.Manifest.Model.ScriptsList.ObjectFactory;
using Dazinate.Dnn.Manifest.Writer;

namespace Dazinate.Dnn.Manifest.Model.ScriptsList
{
    [ObjectFactory(typeof(IScriptsListObjectFactory))]
    [Serializable]
    public class ScriptsList : BusinessListBase<ScriptsList, IScript>, IScriptsList
    {
        // private readonly IPackageFactory _factory;

        public ScriptsList()
        {
        }

        public void Accept(IManifestXmlWriterVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}