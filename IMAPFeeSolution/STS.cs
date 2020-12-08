using System;
using System.Data;

namespace IMAPFeeSolution
{
    public class STS
    {
        public string TenantID { get; set; }
        public string ApplicationId { get; set; }
        public string AuthenticationKey { get; set; }
        public string SubscriptionId { get; set; }
        public string ResourceGroup { get; set; }
        public string  DataFactoryName { get; set; }
        public string  PipelineName { get; set; }
        
        public int jobid;
        public STS(int jobid)
        {
            this.jobid = jobid;
            AssignValues();
        }

        public void AssignValues()
        {
            DataTable dt=IMAPFeeSolutionDO.GetJobSpecificConfig(jobid);

            foreach(DataRow dr in dt.Rows)
            {
               string key= dr["key"].ToString();
                switch (key)
                {
                    case "HIMACS.IMAPFeeSolution.TenantID":
                        TenantID = dr["value"].ToString();
                        break;
                    case "HIMACS.IMAPFeeSolution.ApplicationId":
                        ApplicationId = dr["value"].ToString();
                        break;
                    case "HIMACS.IMAPFeeSolution.AuthenticationKey":
                        AuthenticationKey = dr["value"].ToString();
                        break;
                    case "HIMACS.IMAPFeeSolution.SubscriptionId":
                        SubscriptionId = dr["value"].ToString();
                        break;
                    case "HIMACS.IMAPFeeSolution.ResourceGroup":
                        ResourceGroup = dr["value"].ToString();
                        break;
                    case "HIMACS.IMAPFeeSolution.dataFactoryName":
                        DataFactoryName = dr["value"].ToString();
                        break;
                    case "HIMACS.IMAPFeeSolution.PipelineName ":
                        PipelineName = dr["value"].ToString();
                        break;
                }
            }

        }
    }
}
