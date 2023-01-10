using ConsoleAppToWebApi.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ConsoleAppToWebApi.Custom_Model_Binders
{
    public class CustomBinderCountryDetails : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var modelName = bindingContext.ModelName;
            var value = bindingContext.ValueProvider.GetValue(modelName);
            var result = value.FirstValue;

            if(!int.TryParse(result, out var id))
            {
                return Task.CompletedTask;
            }

            var model = new CountryModel()
            {
                Id = id,
                Name = "India",
                PostalCode = "100",
                CountryPopulation= "1000000"
            };
            bindingContext.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;

        }
    }
}
