// using System.Collections.Generic;
// using Common.Analytics;
// using Common.Analytics.Providers;
// using UnityEngine;
//
// namespace AnalyticsPackage.Scripts
// {
//     public class AppMetricaAnalyticsProvider : IAnalyticProvider
//     {
//         private bool isActive = false;
//
//         public AppMetricaAnalyticsProvider()
//         {
//             if (Application.isEditor)
//             {
//                 return;
//             }
//             
//             var metrica = AppMetrica.Instance;
//
//             isActive = true;
//         }
//
//
//         public void Send(string eventName, Dictionary<string, object> data, int importanceCode)
//         {
//             if (!isActive) return;
//             
//             AppMetrica.Instance.ReportEvent(eventName, data);
//         }
//         
//         public void SendPurchase(PurchaseAnalyticsData purchaseAnalyticsData)
//         {
//             if (!isActive) return;
// //             
// //             Debug.Log($"AppMetrica send purchase: {purchaseAnalyticsData.GetCurrencyValueString()} {purchaseAnalyticsData.IsoCurrencyCode}");
// //             
// //             var receipt = new YandexAppMetricaReceipt();
// //             receipt.Signature = purchaseAnalyticsData.Signature;
// //             receipt.TransactionID = purchaseAnalyticsData.TransactionId;
// //
// // #if UNITY_ANDROID
// //             receipt.Data = purchaseAnalyticsData.PurchaseData;
// // #endif
// //             
// // #if UNITY_IOS
// //             receipt.Data = purchaseAnalyticsData.Payload;
// //             Debug.Log($"receipt Data = {receipt.Data}; sugnature = {receipt.Signature} transctionId = {receipt.TransactionID}.");
// // #endif
// //             var currencyValue = (decimal)purchaseAnalyticsData.CurrencyValue;
// //
// //             var revenue = new YandexAppMetricaRevenue(currencyValue, purchaseAnalyticsData.IsoCurrencyCode) {Receipt = receipt};
// //
// //             AppMetrica.Instance.ReportRevenue(revenue);
// //             
// //             Debug.Log($"AppMetrica send purchase end");
//         }
//
//         public void SendSubscription(SubscriptionAnalyticsData subscriptionAnalyticsData)
//         {
//             if (!isActive) return;
//         }
//
//         public void SetUserProperty(string name, object property)
//         {
//             if (!isActive) return;
//         }
//
//         public void OnApplicationPause(bool pauseStatus)
//         {
//           
//         }
//     }
// }