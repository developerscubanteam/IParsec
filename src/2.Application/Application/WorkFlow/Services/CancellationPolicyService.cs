using Domain.Common.CancellationPolicy;
using Domain.Common.Price;
using Infrastructure.Connectivity.Connector.Models.Message.AvailabilityRS;
using Infrastructure.Connectivity.Connector.Models.Message.Common;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application.WorkFlow.Services
{
    class CancellationPolicyService
    {
        public static CancellationPolicy GetCancellationPolicy(
                   CancelPenalties data,
                   DateTime cheking,
                   string currency,
                   int roomCount = 1)
        {
            CancellationPolicy result = new CancellationPolicy()
            {
                PenaltyRules = new List<PenaltyRule>(),
                Description = data.Description
            };
            if (data.NonRefundable)
            {
                result.PenaltyRules.Add(new () { Type = PolicyRule.NonRefundable, DateFrom = DateTime.Now.AddDays(-1).Date });
            }
            else
            {
                if (data.CancelPenalty != null)
                {
                    foreach (var item in data.CancelPenalty)
                    {
                        result.Description += item.Msg ?? "";
                        if (item.Deadline != null && item.Charge != null)
                        {
                            var totalAmount = item.Charge.Amount * roomCount;
                            if (totalAmount > 0)
                            {
                                result.PenaltyRules.Add( new ()
                                {
                                    Type = PolicyRule.AmountRule,
                                    DateFrom = cheking.AddDays(-item.Deadline.Units),
                                    Price = new Price()
                                    {
                                        Purchase = new Domain.Common.Price.Purchase()
                                        { 
                                            CurrencyCode = currency,
                                            Cost = new Cost()
                                            {
                                                Amount = totalAmount,
                                                Price = item.Charge.Amount.ToString().ToDecimal(),
                                                Quantity = 1
                                            },
                                            Net = totalAmount,
                                            Gross = totalAmount,
                                            CostType = PurchaseCostType.Nett
                                        },
                                    },
                                    CurrencyCode = currency
                                });
                            }
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(result.Description) || string.IsNullOrWhiteSpace(result.Description))
                result.Description = null;

            return result;
        }


    }
}
