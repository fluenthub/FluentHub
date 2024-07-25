// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of SetOrganizationInteractionLimit
	/// </summary>
	public class SetOrganizationInteractionLimitInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The ID of the organization to set a limit for.
		/// </summary>
		public ID OrganizationId { get; set; }

		/// <summary>
		/// The limit to set.
		/// </summary>
		public RepositoryInteractionLimit Limit { get; set; }

		/// <summary>
		/// When this limit should expire.
		/// </summary>
		public RepositoryInteractionLimitExpiry? Expiry { get; set; }
	}
}
