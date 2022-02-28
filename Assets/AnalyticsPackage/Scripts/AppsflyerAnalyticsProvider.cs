// using System.Collections.Generic;
// using Common.Analytics;
// using Common.Analytics.Providers;
// using UnityEngine;
//
// namespace AnalyticsPackage.Scripts
// {
//     public class AppsflyerAnalyticsProvider : IAnalyticProvider
//     {
//         private IAnalyticProvider _analyticProviderImplementation;
//
//         private const string DevKey = "testDevKey";
//         private const string AppID = "";
//
//         // private static readonly List<string> AppsflyerEvents = new List<string>()
//         // {
//         //     "1xInter_viewed",
//         //     "int_viewedx5",
//         //     "int_viewedx10",
//         //     "int_viewedx15",
//         //     "1xRevard_viewed",
//         //     "rev_viewedx5",
//         //     "rev_viewedx10",
//         //     "rev_viewedx15",
//         //     "af_retain1d",
//         //     "Level2_achieved",
//         //     "INT_viewed",
//         //     "RV_viewed",
//         //     "level_up"
//         //
//         // };
//
//
//         public AppsflyerAnalyticsProvider()
//         {
//             if (Application.isEditor) return;
//
//             InitAppsFlyer();
//         }
//
//         private void InitAppsFlyer()
//         {
//             AppsFlyer.initSDK(DevKey, AppID);
//             AppsFlyer.startSDK();
//         }
//
//         public void Send(string eventName, Dictionary<string, object> data, int importanceCode)
//         {
//             if (Application.isEditor) return;
//
//             // if (!IsAppsflyerEvent(eventName))
//             // {
//             //     return;
//             // }
//             //
//             // Dictionary<string, string> dString;
//             // if (data != null)
//             // {
//             //     dString = data.ToDictionary(k => k.Key, k => k.Value.ToString());
//             // }
//             // else
//             // {
//             //     dString = new Dictionary<string, string>();
//             // }
//             //
//             // if (!dString.ContainsKey("appsflyer_id"))
//             // {
//             //     dString.Add("appsflyer_id", AppsFlyer.getAppsFlyerId());
//             // }
//             //
//             // AppsFlyer.sendEvent(eventName, dString);
//         }
//
//         // private bool IsAppsflyerEvent(string eventName)
//         // {
//         //     foreach (var appsflyerEvent in AppsflyerEvents)
//         //     {
//         //         if (appsflyerEvent == eventName)
//         //         {
//         //             return true;
//         //         }
//         //     }
//         //
//         //     return false;
//         // }
//
//         public void SendPurchase(PurchaseAnalyticsData purchaseAnalyticsData)
//         {
//             if (Application.isEditor) return;
//
//             Debug.Log(
//                 $"Appsflyer send purchase: LocalizedPrice = {purchaseAnalyticsData.LocalizedPrice}; IsoCurrencyCode = {purchaseAnalyticsData.IsoCurrencyCode}; LocalizedPriceString = {purchaseAnalyticsData.GetFormatLocalizedPriceString()}");
//
//             // var testLocalizedPrice = purchaseAnalyticsData.LocalizedPrice + 0.01m;
//             // Debug.Log($"TestAppsflyer send purchase: TestLocalizedPrice = {testLocalizedPrice}; TestLocalizedPriceString = {testLocalizedPrice.ToString()}");
//             // Debug.Log($"TestTryCorrect Appsflyer send purchase: TestLocalizedPrice = {testLocalizedPrice}; TryCorrectLocalizedPriceString = {testLocalizedPrice.ToString("F", CultureInfo.InvariantCulture)}");
//
//             // var additionalParameters = new Dictionary<string, string>
//             // {
//             //     {AFInAppEvents.QUANTITY, "1"},
//             // };
//
// // #if UNITY_ANDROID && !UNITY_EDITOR
// //             AppsFlyerAndroid.validateAndSendInAppPurchase(PurchaseController.AndroidPublicKey, purchaseAnalyticsData.Signature, purchaseAnalyticsData.PurchaseData, purchaseAnalyticsData.GetFormatLocalizedPriceString(),
// //                 purchaseAnalyticsData.IsoCurrencyCode, null, purchaseAnalyticsData.PurchaseControllerGameObject);
// // #endif
// //
// // #if UNITY_IOS && !UNITY_EDITOR 
// //             AppsFlyeriOS.validateAndSendInAppPurchase(purchaseAnalyticsData.ProductName, purchaseAnalyticsData.GetFormatLocalizedPriceString(),
// //                 purchaseAnalyticsData.IsoCurrencyCode, purchaseAnalyticsData.TransactionId, null, purchaseAnalyticsData.PurchaseControllerGameObject);
// // #endif
// //             
// //             Debug.Log($"Appsflyer send purchase end");
//         }
//
//         public void SendSubscription(SubscriptionAnalyticsData subscriptionAnalyticsData)
//         {
//             if (Application.isEditor) return;
//         }
//
//         public void SetUserProperty(string name, object property)
//         {
//         }
//
//         public void OnApplicationPause(bool pauseStatus)
//         {
//         }
//     }
// }