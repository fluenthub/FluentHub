// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of UpdateEnterpriseMembersCanDeleteRepositoriesSetting
	/// </summary>
	public class UpdateEnterpriseMembersCanDeleteRepositoriesSettingInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The ID of the enterprise on which to set the members can delete repositories setting.
		/// </summary>
		public ID EnterpriseId { get; set; }

		/// <summary>
		/// The value for the members can delete repositories setting on the enterprise.
		/// </summary>
		public EnterpriseEnabledDisabledSettingValue SettingValue { get; set; }
	}
}
