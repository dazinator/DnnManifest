using System;
using Csla;
using Csla.Server;
using Dazinate.Dnn.Manifest.Base;
using Dazinate.Dnn.Manifest.Package.Component.Shared.LanguageFile.ObjectFactory;

namespace Dazinate.Dnn.Manifest.Package.Component.Shared.LanguageFile
{
    [ObjectFactory(typeof(ILanguageFilesListObjectFactory))]
    [Serializable]
    public class LanguageFilesList : BusinessListBase<LanguageFilesList, ILanguageFile>, ILanguageFilesList
    {
        // private readonly IPackageFactory _factory;

        public LanguageFilesList()
        {
        }

        public void Accept(IManifestVisitor visitor)
        {
            visitor.Visit(this);
        }

#if !AddNewCoreReturnVoid
        protected override ILanguageFile AddNewCore()
        {
            //base.AddNewCore();
            var item = Csla.DataPortal.Create<LanguageFile>();
            Add(item);
            return item;
        }
#else
        protected override void AddNewCore()
        {
            //base.AddNewCore();
             var item = Csla.DataPortal.Create<LanguageFile>();
            Add(item);           
        }
#endif      

    }
}