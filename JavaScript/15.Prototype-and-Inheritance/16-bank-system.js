function createBankSystem() {
    class BankAccount {
        constructor(accountNumber, balance) {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        deposit(amount) {
            this.balance += amount;
        }

        withdraw(amount) {
            if (amount <= this.balance) {
                this.balance -= amount;
            }
        }

        getBalance() {
            return this.balance;
        }
    }

    class SavingsAccount extends BankAccount {
        constructor(accountNumber, balance, interestRate) {
            super(accountNumber, balance);
            this.interestRate = interestRate;
        }

        applyInterest() {
            this.balance += this.balance * this.interestRate;
        }
    }

    class CheckingAccount extends BankAccount {
        constructor(accountNumber, balance, overdraftLimit) {
            super(accountNumber, balance);
            this.overdraftLimit = overdraftLimit;
        }

        withdraw(amount) {
            if (amount <= this.overdraftLimit) {
                super.withdraw();
            }
        }
    }

    return {BankAccount, SavingsAccount, CheckingAccount};
}