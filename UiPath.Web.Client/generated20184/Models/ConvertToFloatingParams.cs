// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ConvertToFloatingParams
    {
        /// <summary>
        /// Initializes a new instance of the ConvertToFloatingParams class.
        /// </summary>
        public ConvertToFloatingParams()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConvertToFloatingParams class.
        /// </summary>
        public ConvertToFloatingParams(long robotId)
        {
            RobotId = robotId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "robotId")]
        public long RobotId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}