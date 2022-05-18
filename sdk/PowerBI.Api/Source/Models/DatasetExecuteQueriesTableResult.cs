// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A table of data
    /// </summary>
    public partial class DatasetExecuteQueriesTableResult
    {
        /// <summary>
        /// Initializes a new instance of the DatasetExecuteQueriesTableResult
        /// class.
        /// </summary>
        public DatasetExecuteQueriesTableResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetExecuteQueriesTableResult
        /// class.
        /// </summary>
        /// <param name="rows">A list of rows</param>
        /// <param name="error">The details of an error, if present.</param>
        public DatasetExecuteQueriesTableResult(IList<object> rows = default(IList<object>), DatasetExecuteQueriesError error = default(DatasetExecuteQueriesError))
        {
            Rows = rows;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of rows
        /// </summary>
        [JsonProperty(PropertyName = "rows")]
        public IList<object> Rows { get; set; }

        /// <summary>
        /// Gets or sets the details of an error, if present.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public DatasetExecuteQueriesError Error { get; set; }

    }
}