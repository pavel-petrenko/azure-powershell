// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Recovery plan creation properties.
    /// </summary>
    public partial class CreateRecoveryPlanInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the CreateRecoveryPlanInputProperties class.
        /// </summary>
        public CreateRecoveryPlanInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateRecoveryPlanInputProperties class.
        /// </summary>

        /// <param name="primaryFabricId">The primary fabric Id.
        /// </param>

        /// <param name="recoveryFabricId">The recovery fabric Id.
        /// </param>

        /// <param name="failoverDeploymentModel">The failover deployment model.
        /// Possible values include: &#39;NotApplicable&#39;, &#39;Classic&#39;, &#39;ResourceManager&#39;</param>

        /// <param name="groups">The recovery plan groups.
        /// </param>

        /// <param name="providerSpecificInput">The provider specific input.
        /// </param>
        public CreateRecoveryPlanInputProperties(string primaryFabricId, string recoveryFabricId, System.Collections.Generic.IList<RecoveryPlanGroup> groups, string failoverDeploymentModel = default(string), System.Collections.Generic.IList<RecoveryPlanProviderSpecificInput> providerSpecificInput = default(System.Collections.Generic.IList<RecoveryPlanProviderSpecificInput>))

        {
            this.PrimaryFabricId = primaryFabricId;
            this.RecoveryFabricId = recoveryFabricId;
            this.FailoverDeploymentModel = failoverDeploymentModel;
            this.Groups = groups;
            this.ProviderSpecificInput = providerSpecificInput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the primary fabric Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "primaryFabricId")]
        public string PrimaryFabricId {get; set; }

        /// <summary>
        /// Gets or sets the recovery fabric Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryFabricId")]
        public string RecoveryFabricId {get; set; }

        /// <summary>
        /// Gets or sets the failover deployment model. Possible values include: &#39;NotApplicable&#39;, &#39;Classic&#39;, &#39;ResourceManager&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "failoverDeploymentModel")]
        public string FailoverDeploymentModel {get; set; }

        /// <summary>
        /// Gets or sets the recovery plan groups.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "groups")]
        public System.Collections.Generic.IList<RecoveryPlanGroup> Groups {get; set; }

        /// <summary>
        /// Gets or sets the provider specific input.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "providerSpecificInput")]
        public System.Collections.Generic.IList<RecoveryPlanProviderSpecificInput> ProviderSpecificInput {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.PrimaryFabricId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PrimaryFabricId");
            }
            if (this.RecoveryFabricId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "RecoveryFabricId");
            }
            if (this.Groups == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Groups");
            }



            if (this.Groups != null)
            {
                foreach (var element in this.Groups)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }

        }
    }
}