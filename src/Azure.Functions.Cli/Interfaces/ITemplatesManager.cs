﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Functions.Cli.Common;

namespace Azure.Functions.Cli.Interfaces
{
    interface ITemplatesManager
    {
        Task<IEnumerable<Template>> Templates { get; }

        Task Deploy(string name, string fileName, Template template);
        Task DeployNewTemplate(string fileName, TemplateJob job, NewTemplate template, IDictionary<string, string> variables);

        Task<IEnumerable<NewTemplate>> NewTemplates { get; }
        Task<IEnumerable<UserPrompt>> UserPrompts { get; }
    }
}
