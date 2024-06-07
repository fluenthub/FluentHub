// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of DeclineTopicSuggestion
	/// </summary>
	public class DeclineTopicSuggestionInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The Node ID of the repository.
		/// **Upcoming Change on 2024-04-01 UTC**
		/// **Description:** `repositoryId` will be removed.
		/// **Reason:** Suggested topics are no longer supported
		/// </summary>
		public ID? RepositoryId { get; set; }

		/// <summary>
		/// The name of the suggested topic.
		/// **Upcoming Change on 2024-04-01 UTC**
		/// **Description:** `name` will be removed.
		/// **Reason:** Suggested topics are no longer supported
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The reason why the suggested topic is declined.
		/// **Upcoming Change on 2024-04-01 UTC**
		/// **Description:** `reason` will be removed.
		/// **Reason:** Suggested topics are no longer supported
		/// </summary>
		public TopicSuggestionDeclineReason? Reason { get; set; }
	}
}
