﻿using System.ServiceModel.Activation;
using Questify.Builder.Services.TasksService.DataService.CustomFactories;
using Questify.Builder.Services.TasksService.DataService.Decorators;
using Questify.Builder.Services.TasksService.DataService.Helpers;

namespace Questify.Builder.Services.TasksService.DataService.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CustomBankPropertyResourceDtoService : WcfCustomBankPropertyResourceDtoService
    {
        public CustomBankPropertyResourceDtoService()
            : base(ServiceFactory.GetCustomBankResourceService(), new EnumTranslator())
        {
        }
    }
}
