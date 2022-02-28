// using System.Collections.Generic;
// using Common.Analytics;
// using Common.Analytics.Providers;
//
// namespace AnalyticsPackage.Scripts
// {
//     public class FacebookAnalyticsProvider : IAnalyticProvider 
//     {
//
// //        private static bool firebaseAnalyticsInitialized;
//
//         public FacebookAnalyticsProvider()
//         {
//             
//             
//         }
//
//
//         public void Send(string eventName, Dictionary<string, object> data, int importanceCode)
//         {
//             if (!AnalyticsController.IsEnable) return;
//             
//             if (!FB.IsInitialized) return;
//             
//             // FB.LogAppEvent ( eventName, null, data );
//         }
//
//         
//         public void SendPurchase(PurchaseAnalyticsData purchaseAnalyticsData)
//         {
//             if (!AnalyticsController.IsEnable) return;
//             
//             // if (!FB.IsInitialized) return;
//             //
//             // var iapParameters = new Dictionary<string, object>
//             // {
//             //     ["product"] = tier,
//             //     ["place"] = place
//             // };
//             //
//             // Debug.Log("Send purchase to Facebook: " + currencyValue + " " + isoCurrencyCode);
//             //
//             // FB.LogPurchase(
//             //     currencyValue,
//             //     isoCurrencyCode,
//             //     iapParameters
//             // );
//         }
//
//         public void SendSubscription(SubscriptionAnalyticsData subscriptionAnalyticsData)
//         {
//             if (!AnalyticsController.IsEnable) return;
//             
//             if (!FB.IsInitialized) return;
//         }
//
//         public void SetUserProperty(string name, object property)
//         {
//            
//         }
//
//         public void OnApplicationPause(bool pauseStatus)
//         {
//           
//         }
//     }
// }