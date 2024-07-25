// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of LockLockable
	/// </summary>
	public class LockLockableInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// ID of the item to be locked.
		/// </summary>
		public ID LockableId { get; set; }

		/// <summary>
		/// A reason for why the item will be locked.
		/// </summary>
		public LockReason? LockReason { get; set; }
	}
}
