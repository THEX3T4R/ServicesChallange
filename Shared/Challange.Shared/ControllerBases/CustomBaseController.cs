using System;
using System.Collections.Generic;
using System.Text;
using Challange.Shared.Dtos;
using FreeCourse.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FreeCourse.Shared.ControllerBases
{
    public class CustomBaseController: Microsoft.AspNetCore.Mvc.ControllerBase
    {
         public IActionResult CreateActionResultInstance<T>(Response<T> response)
         {
             return new ObjectResult(response)
             {
                 StatusCode = response.StatusCode
             };
         }
    }
}
