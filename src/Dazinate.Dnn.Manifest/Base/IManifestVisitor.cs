using Dazinate.Dnn.Manifest.Package;
using Dazinate.Dnn.Manifest.Package.Component;
using Dazinate.Dnn.Manifest.Package.Component.Assembly;
using Dazinate.Dnn.Manifest.Package.Component.AuthenticationSystem;
using Dazinate.Dnn.Manifest.Package.Component.Cleanup;
using Dazinate.Dnn.Manifest.Package.Component.Config;
using Dazinate.Dnn.Manifest.Package.Component.Container;
using Dazinate.Dnn.Manifest.Package.Component.CoreLanguage;
using Dazinate.Dnn.Manifest.Package.Component.DashboardControl;
using Dazinate.Dnn.Manifest.Package.Component.ExtensionLanguage;
using Dazinate.Dnn.Manifest.Package.Component.File;
using Dazinate.Dnn.Manifest.Package.Component.JavascriptFile;
using Dazinate.Dnn.Manifest.Package.Component.JavascriptLibrary;
using Dazinate.Dnn.Manifest.Package.Component.Module;
using Dazinate.Dnn.Manifest.Package.Component.Provider;
using Dazinate.Dnn.Manifest.Package.Component.ResourceFile;
using Dazinate.Dnn.Manifest.Package.Component.Script;
using Dazinate.Dnn.Manifest.Package.Component.Shared.File;
using Dazinate.Dnn.Manifest.Package.Component.Shared.LanguageFile;
using Dazinate.Dnn.Manifest.Package.Component.Skin;
using Dazinate.Dnn.Manifest.Package.Component.SkinObject;
using Dazinate.Dnn.Manifest.Package.Component.UrlProvider;
using Dazinate.Dnn.Manifest.Package.Dependency;

namespace Dazinate.Dnn.Manifest.Base
{
    public interface IManifestVisitor
    {
        void Visit(IPackagesDnnManifest packagesManifest);
        void Visit(ILicense license);
        void Visit(IOwner owner);
        void Visit(IPackage package);
        void Visit(IPackagesList list);
        void Visit(IReleaseNotes releaseNotes);

        #region Dependencies
        void Visit(IDependenciesList list);
        void Visit(CoreVersionDependency dependency);
        void Visit(ManagedPackageDependency dependency);
        void Visit(PackageDependency dependency);
        void Visit(TypeDependency dependency);
        void Visit(CustomDependency dependency);
        #endregion

        #region components
        void Visit(IAssemblyComponent component);
        void Visit(IAssembliesList list);
        void Visit(IAssembly assembly);
        void Visit(IComponentsList list);
        void Visit(IAuthenticationSystemComponent component);
        void Visit(File file);
        void Visit(IFilesList list);
        void Visit(ICleanupComponent component);
        void Visit(INode node);
        void Visit(INodesList list);
        void Visit(IConfigComponent component);
        void Visit(IContainerFilesList list);
        void Visit(IContainerComponent component);
        void Visit(ContainerFile file);
        void Visit(DashboardControlComponent component);
        void Visit(DashboardControlsList list);
        void Visit(DashboardControl dashboardControl);
        void Visit(FileComponent component);
        void Visit(LanguageFilesList list);
        void Visit(LanguageFile languageFile);
        void Visit(CoreLanguageComponent component);
        void Visit(ExtensionLanguageComponent component);
        void Visit(ModuleComponent component);
        void Visit(EventMessage eventMessage);
        void Visit(EventAttribute eventAttribute);
        void Visit(EventAttributesList list);
        void Visit(SupportedFeaturesList list);
        void Visit(SupportedFeature supportedFeature);
        void Visit(ModuleDefinition moduleDefinition);
        void Visit(ModulePermission modulePermission);
        void Visit(ModulePermissionsList list);
        void Visit(ModuleControl moduleControl);
        void Visit(ModuleControlsList list);
        void Visit(ModuleDefinitionsList list);
        void Visit(ProviderComponent component);
        void Visit(ResourceFileComponent component);
        void Visit(ResourceFilesList list);
        void Visit(ResourceFile file);
        void Visit(Script script);
        void Visit(ScriptsList list);
        void Visit(ScriptComponent component);
        void Visit(UrlProviderComponent component);
        void Visit(SkinObjectComponent component);
        void Visit(SkinFile file);
        void Visit(SkinFilesList list);
        void Visit(SkinComponent component);
        void Visit(JavascriptFile file);
        void Visit(JavascriptFilesList list);
        void Visit(JavascriptFileComponent component);
        void Visit(JavascriptLibraryComponent component);
        #endregion
    }
}