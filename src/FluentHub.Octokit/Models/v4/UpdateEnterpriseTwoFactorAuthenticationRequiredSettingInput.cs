// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of UpdateEnterpriseTwoFactorAuthenticationRequiredSetting
	/// </summary>
	public class UpdateEnterpriseTwoFactorAuthenticationRequiredSettingInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The ID of the enterprise on which to set the two factor authentication required setting.
		/// </summary>
		public ID EnterpriseId { get; set; }

		/// <summary>
		/// The value for the two factor authentication required setting on the enterprise.
		/// </summary>
		public EnterpriseEnabledSettingValue SettingValue { get; set; }
	}
}
