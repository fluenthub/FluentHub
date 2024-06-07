// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of StartOrganizationMigration
	/// </summary>
	public class StartOrganizationMigrationInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The URL of the organization to migrate.
		/// </summary>
		public string SourceOrgUrl { get; set; }

		/// <summary>
		/// The name of the target organization.
		/// </summary>
		public string TargetOrgName { get; set; }

		/// <summary>
		/// The ID of the enterprise the target organization belongs to.
		/// </summary>
		public ID TargetEnterpriseId { get; set; }

		/// <summary>
		/// The migration source access token.
		/// </summary>
		public string SourceAccessToken { get; set; }
	}
}
