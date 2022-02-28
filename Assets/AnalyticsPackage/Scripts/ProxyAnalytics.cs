// using System.Collections.Generic;
//
// namespace AnalyticsPackage.Scripts
// {
//     public static class ProxyAnalytics
//     {
//         
//         public static void SendExample(string nameBuilding, double amountSpentResources, string reason)
//         {
//             AnalyticsController.RawEvent("building_process", new Dictionary<string, object>
//             {
//                 {"building_id", nameBuilding},
//                 {"amount", amountSpentResources},
//                 {"reason", reason}
//             }, 0);
//         }
//     
//         public static void TimeFunnel(int time)
//         {
//             AnalyticsController.RawEvent("Time funnel", new Dictionary<string, object>
//             {
//                 {"time stamp",time}
//             }, 1);
//         }
//     }
// }
