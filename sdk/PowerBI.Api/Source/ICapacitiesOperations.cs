// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CapacitiesOperations operations.
    /// </summary>
    public partial interface ICapacitiesOperations
    {
        /// <summary>
        /// Returns a list of capacities the user has access to.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Capacity.Read.All or
        /// Capacity.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Capacities>> GetCapacitiesWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the current state of the specified capacity workloads, if a
        /// workload is enabled also returns the maximum memory percentage that
        /// the workload can consume.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Note:** Workload APIs are not relevant for [Embedded
        /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
        /// capacities.&lt;br/&gt;**Required scope**: Capacity.Read.All or
        /// Capacity.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='capacityId'>
        /// The capacity Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Workloads>> GetWorkloadsWithHttpMessagesAsync(System.Guid capacityId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the current state of a workload and if the workload is
        /// enabled also returns the maximum memory percentage that the
        /// workload can consume.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Note:** Workload APIs are not relevant for [Embedded
        /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
        /// capacities.&lt;br/&gt;**Required scope**: Capacity.Read.All or
        /// Capacity.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='capacityId'>
        /// The capacity Id
        /// </param>
        /// <param name='workloadName'>
        /// The name of the workload
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Workload>> GetWorkloadWithHttpMessagesAsync(System.Guid capacityId, string workloadName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Changes the state of a specific workload to Enabled or Disabled.
        /// When enabling a workload the maximum memory percentage that the
        /// workload can consume must be set.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Note:** Workload APIs are not relevant for [Embedded
        /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
        /// capacities.&lt;br/&gt;**Required scope**: Capacity.ReadWrite.All
        /// &lt;br/&gt;To set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='capacityId'>
        /// The capacity Id
        /// </param>
        /// <param name='workloadName'>
        /// The name of the workload
        /// </param>
        /// <param name='workload'>
        /// Patch workload parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> PatchWorkloadWithHttpMessagesAsync(System.Guid capacityId, string workloadName, PatchWorkloadRequest workload, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of refreshables for all capacities of which the user
        /// has access to.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Capacity.Read.All or
        /// Capacity.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='expand'>
        /// Expands related entities inline, receives a comma-separated list of
        /// data types. Supported: capacities and groups
        /// </param>
        /// <param name='filter'>
        /// Filters the results based on a boolean condition
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results. Use with top to fetch results beyond the
        /// first 1000.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Refreshables>> GetRefreshablesWithHttpMessagesAsync(int top, string expand = default(string), string filter = default(string), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of refreshables for the specified capacity the user
        /// has access to
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Capacity.Read.All or
        /// Capacity.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='capacityId'>
        /// The capacity id
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='expand'>
        /// Expands related entities inline, receives a comma-separated list of
        /// data types. Supported: capacities and groups
        /// </param>
        /// <param name='filter'>
        /// Filters the results based on a boolean condition
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results. Use with top to fetch results beyond the
        /// first 1000.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Refreshables>> GetRefreshablesForCapacityWithHttpMessagesAsync(System.Guid capacityId, int top, string expand = default(string), string filter = default(string), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified refreshable for the specified capacity the
        /// user has access to
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Capacity.Read.All or
        /// Capacity.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='capacityId'>
        /// The capacity id
        /// </param>
        /// <param name='refreshableId'>
        /// The refreshable id
        /// </param>
        /// <param name='expand'>
        /// Expands related entities inline, receives a comma-separated list of
        /// data types. Supported: capacities and groups
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Refreshables>> GetRefreshableForCapacityWithHttpMessagesAsync(System.Guid capacityId, string refreshableId, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Assigns the provided workspaces to the specified capacity.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All
        /// or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='requestParameters'>
        /// Admin assign workspaces capacity parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AssignWorkspacesToCapacityWithHttpMessagesAsync(AssignWorkspacesToCapacityRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Unassigns the provided workspaces from capacity.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All
        /// or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='requestParameters'>
        /// Admin assign workspaces to shared capacity parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UnassignWorkspacesFromCapacityWithHttpMessagesAsync(UnassignWorkspacesCapacityRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}