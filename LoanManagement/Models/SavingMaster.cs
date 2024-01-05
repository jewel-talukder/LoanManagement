namespace LoanManagement.Models
{
    public class SavingMaster
    {
        public int SavingMasterId { get; set; }
        public int CustomerId { get; set; }
        public int InterestRate { get; set; }
        public int MinBalance { get; set; }
        public int MaxBalance { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public int MinTerm { get; set; }
        public int MaxTerm { get; set; }
        public int MinDeposit { get; set; }
        public int MaxDeposit { get; set; }
        public int MinWithdraw { get; set; }
        public int MaxWithdraw { get; set; }
        public int MinPenalty { get; set; }
        public int MaxPenalty { get; set; }
        public int MinInterest { get; set; }
        public int MaxInterest { get; set; }
        public int MinBalanceToEarn { get; set; }
        public int MaxBalanceToEarn { get; set; }
        public int MinBalanceToMaintain { get; set; }
        public int MaxBalanceToMaintain { get; set; }
        public int MinBalanceToWithdraw { get; set; }
        public int MaxBalanceToWithdraw { get; set; }
        public int MinBalanceToClose { get; set; }
        public int MaxBalanceToClose { get; set; }
        public int MinBalanceToReopen { get; set; }
        public int MaxBalanceToReopen { get; set; }
        public int MinBalanceToTransfer { get; set; }
        public int MaxBalanceToTransfer { get; set; }
        public int MinBalanceToLoan { get; set; }
        public int MaxBalanceToLoan { get; set; }
        public int MinBalanceToPay { get; set; }
        public int MaxBalanceToPay { get; set; }
        public int MinBalanceToWithdrawPenalty { get; set; }
        public int MaxBalanceToWithdrawPenalty { get; set; }
        public int MinBalanceToWithdrawInterest { get; set; }
        public int MaxBalanceToWithdrawInterest { get; set; }
        public int MinBalanceToWithdrawSavings { get; set; }
        public int MaxBalanceToWithdrawSavings { get; set; }
        public int MinBalanceToWithdrawLoan { get; set}
    }
}
