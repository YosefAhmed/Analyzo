using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace Union_Cup
{
    interface IAnalysisApi
    {
        [Post("/sentiment_analysis")]
        Task<AnalysisRes> getAnalysis([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> data);
    }
}
