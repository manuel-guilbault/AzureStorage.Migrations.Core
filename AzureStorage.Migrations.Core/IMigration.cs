﻿using System.Threading.Tasks;

namespace AzureStorage.Migrations.Core
{
    public interface IMigration
    {
        Task ExecuteAsync(MigrationContext context);
    }
}
