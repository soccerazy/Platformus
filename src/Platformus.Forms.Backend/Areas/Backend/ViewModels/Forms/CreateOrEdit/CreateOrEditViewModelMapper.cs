﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Platformus.Barebone;
using Platformus.Forms.Data.Abstractions;
using Platformus.Forms.Data.Models;
using Platformus.Globalization.Backend.ViewModels;

namespace Platformus.Forms.Backend.ViewModels.Forms
{
  public class CreateOrEditViewModelMapper : ViewModelBuilderBase
  {
    public CreateOrEditViewModelMapper(IHandler handler)
      : base(handler)
    {
    }

    public Form Map(CreateOrEditViewModel createOrEdit)
    {
      Form form = new Form();

      if (createOrEdit.Id != null)
        form = this.handler.Storage.GetRepository<IFormRepository>().WithKey((int)createOrEdit.Id);

      form.Code = createOrEdit.Code;
      form.Email = createOrEdit.Email;
      return form;
    }
  }
}