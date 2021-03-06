﻿using AzureStorage.Migrations.Core;
using AzureStorage.Migrations.Runner.Storage;
using System;
using System.Linq;

namespace AzureStorage.Migrations.Runner
{
    public class MigrationDefinition
    {
        public MigrationDefinition(int version, string[] tags, IMigration migration)
        {
            Version = version;
            Tags = tags ?? throw new ArgumentNullException(nameof(tags));
            Migration = migration ?? throw new ArgumentNullException(nameof(migration));
        }

        public int Version { get; }
        public string[] Tags { get; }
        public IMigration Migration { get; }

        public bool Matches(params string[] tags)
            => tags == null || tags.Length == 0 || tags.All(x => this.Tags.Contains(x));

        public ExecutedMigration AsExecuted()
            => new ExecutedMigration(Version, DateTime.Now);
    }
}
