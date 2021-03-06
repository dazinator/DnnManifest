﻿using System;
using Dazinate.Dnn.Manifest.Package;

namespace Dazinate.Dnn.Manifest.Factory
{
    [Serializable]
    internal class PackageFactory : IPackageFactory
    {
        public IPackage CreateNew()
        {
            return Csla.DataPortal.Create<Package.Package>();
        }
    }
}