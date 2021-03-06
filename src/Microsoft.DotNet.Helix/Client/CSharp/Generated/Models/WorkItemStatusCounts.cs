// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class WorkItemStatusCounts
    {
        /// <summary>
        /// Initializes a new instance of the WorkItemStatusCounts class.
        /// </summary>
        public WorkItemStatusCounts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkItemStatusCounts class.
        /// </summary>
        public WorkItemStatusCounts(IList<AnalysisCount> analysis, IDictionary<string, int?> workItemStatus)
        {
            Analysis = analysis;
            WorkItemStatus = workItemStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Analysis")]
        public IList<AnalysisCount> Analysis { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "WorkItemStatus")]
        public IDictionary<string, int?> WorkItemStatus { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Analysis == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Analysis");
            }
            if (WorkItemStatus == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WorkItemStatus");
            }
            if (Analysis != null)
            {
                foreach (var element in Analysis)
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
