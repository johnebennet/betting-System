﻿namespace BettingSystem.Web.ModelBinders
{
    using System.Linq;
    using System.Threading.Tasks;
    using Application.Common.Images;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public class ImageFormFileModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var formFile = bindingContext
                .ActionContext
                .HttpContext
                .Request
                .Form
                .Files
                .FirstOrDefault();

            if (formFile == null)
            {
                bindingContext.Result = ModelBindingResult.Failed();
            }
            else
            {
                var imageRequest = new ImageRequestModel(formFile.OpenReadStream());
                bindingContext.Result = ModelBindingResult.Success(imageRequest);
            }

            return Task.CompletedTask;
        }
    }
}
