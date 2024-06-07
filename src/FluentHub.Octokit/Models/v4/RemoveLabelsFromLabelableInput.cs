// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of RemoveLabelsFromLabelable
	/// </summary>
	public class RemoveLabelsFromLabelableInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The id of the Labelable to remove labels from.
		/// </summary>
		public ID LabelableId { get; set; }

		/// <summary>
		/// The ids of labels to remove.
		/// </summary>
		public List<ID> LabelIds { get; set; }
	}
}
