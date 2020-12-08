using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Rest;
using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Azure.Management.DataFactory;
using Microsoft.Azure.Management.DataFactory.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Azure.Services.AppAuthentication;
using ADFPipelineLibrary;

namespace IMAPFeeSolution
{
    public class IMAPFeeSolutionService
    {
        STS sts;
        ADFPipeline pipeline;
        public void Service(int JobId)
        {
            sts = new STS(JobId);
            pipeline = new ADFPipeline(sts.TenantID, sts.ApplicationId, sts.AuthenticationKey, sts.SubscriptionId, sts.ResourceGroup, sts.DataFactoryName, sts.PipelineName);
            pipeline.PipelineRun();
            pipeline.PipelineMonitor();
        }
    }
}
