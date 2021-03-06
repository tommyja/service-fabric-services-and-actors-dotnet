﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------
namespace Microsoft.ServiceFabric.Services.Remoting.Builder
{
    using System;
    using System.Globalization;

    abstract class CodeBuilderNames : ICodeBuilderNames
    {
        private readonly string namePrefix;

        protected CodeBuilderNames()
            : this("gen")
        {
        }

        protected CodeBuilderNames(string namePrefix)
        {
            this.namePrefix = namePrefix;
        }

        public string InterfaceId
        {
            get { return "interfaceId"; }
        }

        public string MethodId
        {
            get { return "methodId"; }
        }

        public string RetVal
        {
            get { return "retVal"; }
        }

        public string RequestBody
        {
            get { return "requestBody"; }
        }

        public string GetMethodBodyTypesAssemblyName(Type interfaceType)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}_.{1}.mt", interfaceType.FullName, this.namePrefix);
        }

        public string GetMethodBodyTypesAssemblyNamespace(Type interfaceType)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}_.{1}.mt", interfaceType.FullName, this.namePrefix);
        }
        public string GetRequestBodyTypeName(string methodName)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}ReqBody", methodName);
        }

        public string GetResponseBodyTypeName(string methodName)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}RespBody", methodName);
        }

        public string GetMethodDispatcherAssemblyName(Type interfaceType)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}_.{1}.disp", interfaceType.FullName, this.namePrefix);
        }

        public string GetMethodDispatcherAssemblyNamespace(Type interfaceType)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}_.{1}.disp", interfaceType.FullName, this.namePrefix);
        }

        public string GetMethodDispatcherClassName(Type interfaceType)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}MethodDispatcher", interfaceType.Name);
        }

        public string GetProxyAssemblyName(Type interfaceType)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}_.{1}.proxy", interfaceType.FullName, this.namePrefix);
        }

        public string GetProxyAssemblyNamespace(Type interfaceType)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}_.{1}.proxy", interfaceType.FullName, this.namePrefix);
        }

        public string GetProxyClassName(Type interfaceType)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}{1}Proxy", interfaceType.Name, this.namePrefix);
        }

        public string GetProxyActivatorClassName(Type interfaceType)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}{1}ProxyActivator", interfaceType.Name, this.namePrefix);
        }

        public abstract string GetDataContractNamespace();
    }
}
