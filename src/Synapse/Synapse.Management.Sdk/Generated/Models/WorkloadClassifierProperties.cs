// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Workload classifier definition. For more information look at
    /// sys.workload_management_workload_classifiers (DMV).
    /// </summary>
    public partial class WorkloadClassifierProperties
    {
        /// <summary>
        /// Initializes a new instance of the WorkloadClassifierProperties class.
        /// </summary>
        public WorkloadClassifierProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkloadClassifierProperties class.
        /// </summary>

        /// <param name="memberName">The workload classifier member name.
        /// </param>

        /// <param name="label">The workload classifier label.
        /// </param>

        /// <param name="context">The workload classifier context.
        /// </param>

        /// <param name="startTime">The workload classifier start time for classification.
        /// </param>

        /// <param name="endTime">The workload classifier end time for classification.
        /// </param>

        /// <param name="importance">The workload classifier importance.
        /// </param>
        public WorkloadClassifierProperties(string memberName, string label = default(string), string context = default(string), string startTime = default(string), string endTime = default(string), string importance = default(string))

        {
            this.MemberName = memberName;
            this.Label = label;
            this.Context = context;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Importance = importance;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the workload classifier member name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "memberName")]
        public string MemberName {get; set; }

        /// <summary>
        /// Gets or sets the workload classifier label.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "label")]
        public string Label {get; set; }

        /// <summary>
        /// Gets or sets the workload classifier context.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "context")]
        public string Context {get; set; }

        /// <summary>
        /// Gets or sets the workload classifier start time for classification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public string StartTime {get; set; }

        /// <summary>
        /// Gets or sets the workload classifier end time for classification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public string EndTime {get; set; }

        /// <summary>
        /// Gets or sets the workload classifier importance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "importance")]
        public string Importance {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.MemberName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "MemberName");
            }






        }
    }
}