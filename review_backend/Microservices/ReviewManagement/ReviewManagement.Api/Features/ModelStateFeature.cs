using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ReviewManagement.Api.Features
{
    /// <summary>
    /// Used to access model state in middleware.
    /// </summary>
    public class ModelStateFeature
    {
        public ModelStateFeature(ModelStateDictionary modelState)
        {
            ModelState = modelState;
        }

        public ModelStateDictionary ModelState { get; private set; }
    }
}
