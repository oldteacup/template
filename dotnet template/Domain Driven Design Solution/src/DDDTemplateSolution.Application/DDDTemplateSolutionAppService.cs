using System;
using System.Collections.Generic;
using System.Text;
using DDDTemplateSolution.Localization;
using Volo.Abp.Application.Services;

namespace DDDTemplateSolution;

/* Inherit your application services from this class.
 */
public abstract class DDDTemplateSolutionAppService : ApplicationService
{
    protected DDDTemplateSolutionAppService()
    {
        LocalizationResource = typeof(DDDTemplateSolutionResource);
    }
}
