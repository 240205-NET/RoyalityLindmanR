namespace Banking {
    class Account {
        //fields
            // pin
            // account owner
        private string owner;
            // type of account
            // account number
            
        
        public int accountNumber { get; }

        public void setAccountNuber(int n) {
            if(n == null) {
                throw new Exception(MessageProcessingHandler: "value cannot be null", paramName :nameof(ValueTask))
            }
            this.accountNumber = n;
        }

        // balance
        protected double balance;
        
    private static int accountNumberSeed = 123;

        //constructors
    public  Account(string ownersName, double initialBalance) {
            //create account num

            this.accountNumber = this.accountNumberSeed;
            this.accountNumberSeed++;
            this.owner = ownersName;
            MakeDeposit(initialBalance);
    }

    public  Account(string ownersName) {
            //create account num

            this.accountNumber = this.accountNumberSeed;
            this.accountNumberSeed++;
            this.owner = ownersName;
            MakeDeposit(0);
    }
        

        //methods

            //withdrawls
            //balance
            //deposits

            //associate with another account
            //transfer
            //closing account (remove account info)
    }
}

            //account
                
                
                