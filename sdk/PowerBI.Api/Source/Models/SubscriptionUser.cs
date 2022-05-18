// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using System.Linq;

    /// <summary>
    /// A Power BI email subscription user
    /// </summary>
    public partial class SubscriptionUser : User
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionUser class.
        /// </summary>
        public SubscriptionUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionUser class.
        /// </summary>
        /// <param name="identifier">Identifier of the principal</param>
        /// <param name="principalType">Possible values include: 'None',
        /// 'User', 'Group', 'App'</param>
        /// <param name="emailAddress">Email address of the user</param>
        /// <param name="displayName">Display name of the principal</param>
        /// <param name="graphId">Identifier of the principal in Microsoft
        /// Graph. Only available for admin APIs.</param>
        public SubscriptionUser(string identifier, PrincipalType principalType, string emailAddress = default(string), string displayName = default(string), string graphId = default(string), ServicePrincipalProfile profile = default(ServicePrincipalProfile))
            : base(identifier, principalType, emailAddress, displayName, graphId, profile)
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