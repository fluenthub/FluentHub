namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of CreateMigrationSource
    /// </summary>
    public class CreateMigrationSourceInput
    {
        /// <summary>
        /// The migration source name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The migration source URL, for example `https://github.com` or `https://monalisa.ghe.com`.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The migration source access token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// The migration source type.
        /// </summary>
        public MigrationSourceType Type { get; set; }

        /// <summary>
        /// The ID of the organization that will own the migration source.
        /// </summary>
        public ID OwnerId { get; set; }

        /// <summary>
        /// The GitHub personal access token of the user importing to the target repository.
        /// </summary>
        public string GithubPat { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}