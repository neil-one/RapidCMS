﻿using RapidCMS.Common.Data;
using RapidCMS.Common.Enums;
using RapidCMS.Common.Interfaces;
using System.Threading.Tasks;
using TestLibrary.Entities;
using TestLibrary.Repositories;

#nullable enable

namespace TestServer.ActionHandlers
{
    public class CreateButtonActionHandler : IButtonActionHandler
    {
        private readonly AzureTableStorageRepository _repository;

        public CreateButtonActionHandler(AzureTableStorageRepository repository)
        {
            _repository = repository;
        }

        public CrudType GetCrudType()
        {
            return CrudType.Refresh;
        }

        public async Task InvokeAsync(string? parentId, string? id)
        {
            var i = 0;

            do
            {
                await _repository.InsertAsync(parentId, new AzureTableStorageEntity()
                {
                    Description = $"New New New {i}",
                    Title = $"Item {i}"
                });
            }
            while (++i < 2);
        }

        public bool IsCompatibleWithView(ViewContext viewContext)
        {
            return viewContext.Usage.HasFlag(UsageType.List);
        }

        public bool ShouldConfirm()
        {
            return true;
        }
    }
}