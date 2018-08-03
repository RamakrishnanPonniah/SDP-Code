using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Script.Services;
using System.Web.Services;

namespace SDP.Services
{
    /// <summary>
    /// Summary description for SDPService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class SDPService : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public TransactionResult TransactionEvaluate(TransactionRequest request)
        {
            return new TransactionResult { Value = "My Service is working!" };
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string TransactionService(TransactionRequest request)
        {            
          return  InvokeRequestResponseService(request).Result;
         
        }

        static async Task<string> InvokeRequestResponseService(TransactionRequest request)
        {
            string res = "";
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {

                    Inputs = new Dictionary<string, StringTable>() {
                        {
                            "input1",
                            new StringTable()
                            {
                                ColumnNames = new string[] {
                                      "Card Number"
                                    , "Funding Account Number"
                                    , "Customer ID"
                                    , "Posted Amount (USD)"
                                    , "Authorization Amount (USD)"
                                    , "Txn Timestamp"
                                    , "Authorization Timestamp"
                                    , "Txn_Type"
                                    , "Reference Number"
                                    , "Issuer Country"
                                    , "Merchant Country"
                                    , "Issuer Currency Code"
                                    , "Merchant Currency Code"
                                    , "Merchant Name"
                                    , "Merchant Category Code"
                                    , "Network ID"
                                    , "POS Entry Mode"
                                    , "POS Entry Mode on Auth"
                                    , "POS Environment"
                                    , "Service Code"
                                    , "MOTO_ECI_Ind"
                                    , "Physical Card Present"
                                    , "Terminal Indicator"
                                    , "Terminal capability code"
                                    , "Cardholder ID Method"
                                    , "RPS Ind"
                                    , "UCAF"
                                    , "Floor Limit"
                                    , "CVV2 Result"
                                    , "CAVV Result"
                                    , "Pin Present ?"
                                    , "Acquirer BIN"
                                    , "Card Acceptor ID"
                                    , "Multi Clearing"
                                    , "Authorization code"
                                    , "Case id"
                                    , "Dispute Amount (USD)"
                                    , "On Us"
                                    , "Fraud Reported"
                                    , "Dispute"
                                    , "Decision Type"
                                    , "Chargeback Attempt"
                                    , "Recovered"
                                    , "Dispute Category"
                                    , "Customer Initiated Dispute"
                                    , "Reconsidered Dispute"
                                    , "RFC Fulfilled"
                                    , "Merchant Credit Resolve"
                                    , "Representment Indicator"
                                    , "Dispute Alert Subscription"
                                    , "Potential Dispute Alert to Customer"
                                    , "Potential Dispute Alert to Back Office"
                                    , "Potential Dispute Alert Overridden by Customer"
                                    , "Potential Dispute Alert Honored by Customer"
                                    , "POC"
                                },
                                Values = new string[,] {  
                                { 
                                    request.CardNumber 
                                  , request.FundingAccountNumber 
                                  , request.CustomerID 
                                  , request.PostedAmount 
                                  , request.AuthorizationAmount 
                                  , request.TxnTimestamp 
                                  , request.AuthorizationTimestamp 
                                  , request.Txn_Type 
                                  , request.ReferenceNumber 
                                  , request.IssuerCountry 
                                  , request.MerchantCountry 
                                  , request.IssuerCurrencyCode 
                                  , request.MerchantCurrencyCode 
                                  , request.MerchantName 
                                  , request.MerchantCategoryCode 
                                  , request.NetworkID 
                                  , request.POSEntryMode 
                                  , request.POSEntryModeonAuth 
                                  , request.POSEnvironment 
                                  , request.ServiceCode 
                                  , request.MOTO_ECI_Ind 
                                  , request.PhysicalCardPresent 
                                  , request.TerminalIndicator 
                                  , request.Terminalcapabilitycode 
                                  , request.CardholderIDMethod 
                                  , request.RPSInd 
                                  , request.UCAF 
                                  , request.FloorLimit 
                                  , request.CVV2Result 
                                  , request.CAVVResult 
                                  , request.PinPresent 
                                  , request.AcquirerBIN 
                                  , request.CardAcceptorID 
                                  , request.MultiClearing 
                                  , request.Authorizationcode 
                                  , request.Caseid 
                                  , request.DisputeAmount 
                                  , request.OnUs 
                                  , request.FraudReported 
                                  , request.Dispute 
                                  , request.DecisionType 
                                  , request.ChargebackAttempt 
                                  , request.Recovered 
                                  , request.DisputeCategory 
                                  , request.CustomerInitiatedDispute 
                                  , request.ReconsideredDispute 
                                  , request.RFCFulfilled 
                                  , request.MerchantCreditResolve 
                                  , request.RepresentmentIndicator 
                                  , request.DisputeAlertSubscription 
                                  , request.PotentialDisputeAlerttoCustomer 
                                  , request.PotentialDisputeAlerttoBackOffice 
                                  , request.PotentialDisputeAlertOverriddenbyCustomer 
                                  , request.PotentialDisputeAlertHonoredbyCustomer 
                                  , request.POC 
                                },  
                                { "value", "value", "value", "0", "0", "", ""
                                  , "value", "0", "value", "value", "value"
                                  , "0", "value", "0", "value", "value", "value", "value", "0"
                                  , "value", "value", "value", "value", "value", "value", "value"
                                  , "value", "value", "value", "value", "0", "0", "value", "0"
                                  , "0", "0", "value", "value", "value", "value", "value", "value"
                                  , "value", "value", "value", "value", "value", "value", "value"
                                  , "value", "value", "value", "value", "value" 
                                },  
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };
                const string apiKey = "V6bJKdn0R0Kcu+G8yW6cR9wtmnWJO/x+KOHyNvRVKEd+b5nrzl05C6K6EY1dHEqZRYaRXa1kbc508vsb8OkZtA=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/97483786c0a24d89960516343f205705/services/533d3545aeaf4418900fccca5b9e2f9f/execute?api-version=2.0&details=true");

                // WARNING: The 'await' statement below can result in a deadlock if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false) so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)


                HttpResponseMessage response = await client.PostAsJsonAsync("https://ussouthcentral.services.azureml.net/workspaces/97483786c0a24d89960516343f205705/services/533d3545aeaf4418900fccca5b9e2f9f/execute?api-version=2.0&details=true", scoreRequest);

                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Result: {0}", result);
                res = result;
                //if (response.IsSuccessStatusCode)
                //{
                //    string result = await response.Content.ReadAsStringAsync();
                //    Console.WriteLine("Result: {0}", result);
                //}
                //else
                //{
                //    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                //    // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
                //    Console.WriteLine(response.Headers.ToString());

                //    string responseContent = await response.Content.ReadAsStringAsync();
                //    Console.WriteLine(responseContent);
                //}
            }
            return res;
        }

       

    }


    public class StringTable
    {
        public string[] ColumnNames { get; set; }
        public string[,] Values { get; set; }
    }

    public class TransactionResult
    {
        public string Value { get; set; }
    }

    public class TransactionRequest
    {
        public string CardNumber { get; set; }
        public string FundingAccountNumber { get; set; }
        public string CustomerID { get; set; }
        public string PostedAmount { get; set; }
        public string AuthorizationAmount { get; set; }
        public string TxnTimestamp { get; set; }
        public string AuthorizationTimestamp { get; set; }
        public string Txn_Type { get; set; }
        public string ReferenceNumber { get; set; }
        public string IssuerCountry { get; set; }
        public string MerchantCountry { get; set; }
        public string IssuerCurrencyCode { get; set; }
        public string MerchantCurrencyCode { get; set; }
        public string MerchantName { get; set; }
        public string MerchantCategoryCode { get; set; }
        public string NetworkID { get; set; }
        public string POSEntryMode { get; set; }
        public string POSEntryModeonAuth { get; set; }
        public string POSEnvironment { get; set; }
        public string ServiceCode { get; set; }
        public string MOTO_ECI_Ind { get; set; }
        public string PhysicalCardPresent { get; set; }
        public string TerminalIndicator { get; set; }
        public string Terminalcapabilitycode { get; set; }
        public string CardholderIDMethod { get; set; }
        public string RPSInd { get; set; }
        public string UCAF { get; set; }
        public string FloorLimit { get; set; }
        public string CVV2Result { get; set; }
        public string CAVVResult { get; set; }
        public string PinPresent { get; set; }
        public string AcquirerBIN { get; set; }
        public string CardAcceptorID { get; set; }
        public string MultiClearing { get; set; }
        public string Authorizationcode { get; set; }
        public string Caseid { get; set; }
        public string DisputeAmount { get; set; }
        public string OnUs { get; set; }
        public string FraudReported { get; set; }
        public string Dispute { get; set; }
        public string DecisionType { get; set; }
        public string ChargebackAttempt { get; set; }
        public string Recovered { get; set; }
        public string DisputeCategory { get; set; }
        public string CustomerInitiatedDispute { get; set; }
        public string ReconsideredDispute { get; set; }
        public string RFCFulfilled { get; set; }
        public string MerchantCreditResolve { get; set; }
        public string RepresentmentIndicator { get; set; }
        public string DisputeAlertSubscription { get; set; }
        public string PotentialDisputeAlerttoCustomer { get; set; }
        public string PotentialDisputeAlerttoBackOffice { get; set; }
        public string PotentialDisputeAlertOverriddenbyCustomer { get; set; }
        public string PotentialDisputeAlertHonoredbyCustomer { get; set; }
        public string POC { get; set; }
    }
}
