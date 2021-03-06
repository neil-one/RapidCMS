﻿using System;
using System.Linq;
using RapidCMS.Core.Extensions;

namespace RapidCMS.Core.Helpers
{
    public static class AliasHelper
    {
        public static string GetFileUploaderAlias(Type handlerType)
        {
            var type = (handlerType.IsGenericType && handlerType.GetGenericTypeDefinition().Name.StartsWith("ApiFileUpload"))
                ? handlerType.GetGenericArguments().FirstOrDefault()
                : handlerType;

            return type?.Name.ToSha1Base64String("file-upload-handler") ?? "unknown-file-handler";
        }

        public static string GetRepositoryAlias(Type repositoryType)
        {
            var name = repositoryType?.FullName;
            var alias = name?.ToSha1Base64String("repo") ?? "unknown-repository";

            return alias;
        }

        public static string GetEntityVariantAlias(Type entityType)
        {
            var name = entityType?.FullName;
            var alias = name?.ToSha1Base64String("entity") ?? "unknown-entity";

            return alias;
        }
    }
}
