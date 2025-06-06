// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Static input data definition.</summary>
    public partial class StaticInputData :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IStaticInputData,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IStaticInputDataInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBase __monitoringInputDataBase = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringInputDataBase();

        /// <summary>Mapping of column names to special uses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseColumns Column { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseInternal)__monitoringInputDataBase).Column; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseInternal)__monitoringInputDataBase).Column = value ?? null /* model class */; }

        /// <summary>The context metadata of the data source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string DataContext { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseInternal)__monitoringInputDataBase).DataContext; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseInternal)__monitoringInputDataBase).DataContext = value ?? null; }

        /// <summary>[Required] Specifies the type of signal to monitor.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringInputDataType InputDataType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseInternal)__monitoringInputDataBase).InputDataType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseInternal)__monitoringInputDataBase).InputDataType = value ; }

        /// <summary>[Required] Specifies the type of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType JobInputType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseInternal)__monitoringInputDataBase).JobInputType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseInternal)__monitoringInputDataBase).JobInputType = value ; }

        /// <summary>Backing field for <see cref="PreprocessingComponentId" /> property.</summary>
        private string _preprocessingComponentId;

        /// <summary>Reference to the component asset used to preprocess the data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string PreprocessingComponentId { get => this._preprocessingComponentId; set => this._preprocessingComponentId = value; }

        /// <summary>[Required] Input Asset URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Uri { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseInternal)__monitoringInputDataBase).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseInternal)__monitoringInputDataBase).Uri = value ; }

        /// <summary>Backing field for <see cref="WindowEnd" /> property.</summary>
        private global::System.DateTime _windowEnd;

        /// <summary>[Required] The end date of the data window.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public global::System.DateTime WindowEnd { get => this._windowEnd; set => this._windowEnd = value; }

        /// <summary>Backing field for <see cref="WindowStart" /> property.</summary>
        private global::System.DateTime _windowStart;

        /// <summary>[Required] The start date of the data window.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public global::System.DateTime WindowStart { get => this._windowStart; set => this._windowStart = value; }

        /// <summary>Creates an new <see cref="StaticInputData" /> instance.</summary>
        public StaticInputData()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__monitoringInputDataBase), __monitoringInputDataBase);
            await eventListener.AssertObjectIsValid(nameof(__monitoringInputDataBase), __monitoringInputDataBase);
        }
    }
    /// Static input data definition.
    public partial interface IStaticInputData :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBase
    {
        /// <summary>Reference to the component asset used to preprocess the data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Reference to the component asset used to preprocess the data.",
        SerializedName = @"preprocessingComponentId",
        PossibleTypes = new [] { typeof(string) })]
        string PreprocessingComponentId { get; set; }
        /// <summary>[Required] The end date of the data window.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"[Required] The end date of the data window.",
        SerializedName = @"windowEnd",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime WindowEnd { get; set; }
        /// <summary>[Required] The start date of the data window.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"[Required] The start date of the data window.",
        SerializedName = @"windowStart",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime WindowStart { get; set; }

    }
    /// Static input data definition.
    internal partial interface IStaticInputDataInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseInternal
    {
        /// <summary>Reference to the component asset used to preprocess the data.</summary>
        string PreprocessingComponentId { get; set; }
        /// <summary>[Required] The end date of the data window.</summary>
        global::System.DateTime WindowEnd { get; set; }
        /// <summary>[Required] The start date of the data window.</summary>
        global::System.DateTime WindowStart { get; set; }

    }
}