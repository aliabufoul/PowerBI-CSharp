// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using System.Linq;

    /// <summary>
    /// A request to deploy all supported items from a deployment pipeline
    /// stage
    /// </summary>
    public partial class DeployAllRequest : DeployRequestBase
    {
        /// <summary>
        /// Initializes a new instance of the DeployAllRequest class.
        /// </summary>
        public DeployAllRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeployAllRequest class.
        /// </summary>
        /// <param name="sourceStageOrder">The numeric identifier of the
        /// pipeline deployment stage that the content should be deployed from.
        /// Development (0), Test (1), Production (2).</param>
        /// <param name="isBackwardDeployment">Whether the deployment will be
        /// from a later stage in the deployment pipeline, to an earlier one.
        /// The default value is `false`.</param>
        /// <param name="newWorkspace">The configuration details for creating a
        /// new workspace. Required when deploying to a stage that has no
        /// assigned workspaces. The deployment will fail if the new workspace
        /// configuration details aren't provided when required.</param>
        /// <param name="updateAppSettings">Update org app in the target
        /// workspace settings</param>
        /// <param name="options">Options that control the behavior of the
        /// entire deployment</param>
        public DeployAllRequest(int sourceStageOrder, bool? isBackwardDeployment = default(bool?), PipelineNewWorkspaceRequest newWorkspace = default(PipelineNewWorkspaceRequest), PipelineUpdateAppSettings updateAppSettings = default(PipelineUpdateAppSettings), DeploymentOptions options = default(DeploymentOptions))
            : base(sourceStageOrder, isBackwardDeployment, newWorkspace, updateAppSettings, options)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}