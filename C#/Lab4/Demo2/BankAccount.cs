namespace Demo2
{
    public class BankAccount
    {
        int id;
        string name;
        float balance;

        public void SetId(int _id) { id =  _id; }
        public int GetId() { return id; }
        public void SetName(string _name)
        {
            if (_name.Length < 3 )
                Console.WriteLine("Minimum Character Of Name 3 Characters!");
            else
                name = _name; 
        }
        public string GetName() { return name; }
        public void Deposit(float _amount)
        {
            if (_amount <= 0)
                Console.WriteLine("Invalid Amount!");
            else
                balance += _amount;
        }

        public void Withdraw(float _amount)
        {
            if (_amount <= 0)
                Console.WriteLine("Invalid Amount!");
            else if (_amount > balance || (balance - _amount) < 1000)
                Console.WriteLine($"Account[{id}] Cannot Withdraw {_amount}, Your Current Balance Is {balance} Only!");
            else
                balance -= _amount;
        }

        public float GetBalance() { return balance; }
        public BankAccount(int _id, string _name)
        {
            SetId(_id);
            SetName(_name);
        }

        public BankAccount(int _id, string _name, float _balance) : this(_id, _name)
        {
            Deposit(_balance);
        }

        public void Print()
        {
            Console.WriteLine($"[{id}]: {name}, Current Balance ({balance}) EGP");
        }
    }
}
