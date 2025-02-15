using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Diagnostics;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var constr = configuration.GetSection("constr").Value;
            var connection = new SqlConnection(constr);

            while (true)
            {
                PrintMenu();
                Console.Write("Choice: ");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice)) Console.Write("Choice: ");
                switch (choice)
                {
                    case 1:
                        // Read Data From Database
                        ReadData(connection, "Wallet");
                        break;
                    case 2:
                        ReadDataInDisconnectedMode(connection, "Wallet");
                        break;
                    case 3:
                        // Insert Data Into Database
                        string holder = GetWalletHolder();
                        
                        decimal balance = GetBalance();
                        
                        string sql = "INSERT INTO Wallet VALUES(@holder, @balance); select cast(scope_identity() as int);";
                        ExecutetNonQueryWallet(connection, sql, false, holder, balance);
                        break;
                    case 4:
                        // Insert Data Into Database and get Idnetity (Id)
                        holder = GetWalletHolder();
                        balance = GetBalance();

                        sql = "INSERT INTO Wallet VALUES(@holder, @balance); select cast(scope_identity() as int);";
                        ExecutetNonQueryWallet(connection, sql, true, holder, balance);
                        break;
                    case 5:
                        // Insert Data Using Stored Procedure
                        holder = GetWalletHolder();
                        balance = GetBalance();
                        ExecuteStoredProcedure(connection, "AddWallet", holder, balance);
                        break;
                    case 6:
                        // Update Data In Database
                        holder = GetWalletHolder("Enter Wallet Holder To Update: ");
                        balance = GetBalance("Enter New Balance:");

                        
                        sql = "UPDATE Wallet SET Balance = @balance WHERE Holder = @holder";
                        ExecutetNonQueryWallet(connection, sql, false, holder, balance);
                        break;
                    case 7:
                        // Delete Data From Database
                        holder = GetWalletHolder("Enter Wallet Holder To Delete: ");
                        
                        sql = "DELETE FROM Wallet WHERE Holder = @holder";
                        ExecutetNonQueryWallet(connection, sql, false, holder);
                        break;
                    case 8:
                        holder = GetWalletHolder("Enter Wallet Holder: ");
                        decimal depositAmount = GetBalance("Enter Amount To Deposit: ");
                        decimal withdrawAmount = GetBalance("Enter Amount To Withdraw: ");
                        WidthdrawDepositUsingTransaction(connection,holder, depositAmount, withdrawAmount);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
                Console.WriteLine();  
            }

        }
        static void ReadData(SqlConnection connection, string tableName)
        {
            var sql = $"SELECT * FROM {tableName}";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.CommandType = CommandType.Text;
            connection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                var wallet = new Wallet();
                wallet.Id = reader.GetInt32("Id");
                //wallet.Holder = reader.GetString("holder");
                decimal? x = reader.GetDecimal("balance");
                //reader["holder"].ToString(); //reader.GetString("Holder");
                //string x = reader["balance"].ToString(); //reader.GetDecimal("Balance").ToString();
                // wallet.Balance = reader.GetDecimal("Balance");//Convert.ToDecimal(reader["Balance"].ToString()); 
                Console.WriteLine(wallet);
            }
          
            connection.Close();
        }
        static void ReadDataInDisconnectedMode(SqlConnection connection, string tableName)
        {
            var sql = $"SELECT * FROM {tableName}";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connection);    
            DataTable dt = new DataTable();
            connection.Open();
            sqlDataAdapter.Fill(dt);
            connection.Close();

            
            foreach (DataRow row in dt.Rows)
            {
                var wallet = new Wallet();
                wallet.Id = (int) row["Id"];
                wallet.Holder = (string)row["Holder"];
                wallet.Balance = (decimal)row["Balance"];
                Console.WriteLine(wallet);
            }
        }
        static void ExecutetNonQueryWallet(SqlConnection connection, string sql,bool getId,  string holder, decimal? balance = null)
        {
            var wallet = new Wallet();
            wallet.Holder = holder;
            
;
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            SqlParameter holderParam = new SqlParameter
            {
                ParameterName = "@holder",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = holder,
            };

            command.Parameters.Add(holderParam);

            if (balance is not null)
            {
                 wallet.Balance = balance;
                 SqlParameter balanceParam = new SqlParameter("@balance", wallet.Balance);
                command.Parameters.Add(balanceParam);
            }
            
            connection.Open();
            if (!getId)
            {
                var rowsEffected = command.ExecuteNonQuery();
                if (rowsEffected > 0)
                    Console.WriteLine($"{rowsEffected} Rows Effected.");
                else
                    Console.WriteLine("THIS WALLET IS NOT FOUND!");
            }
            else
            {
                wallet.Id = (int)command.ExecuteScalar();
                Console.WriteLine($"Walletd {wallet.Holder} - ({wallet.Balance})EGP Added Successfully With Id: [{wallet.Id}]");
            }
            connection.Close();
        }

        static void ExecuteStoredProcedure(SqlConnection connection, string procedure, string holder, decimal? balance = null)
        {
            var wallet = new Wallet();
            wallet.Holder = holder;

            
            SqlCommand command = new SqlCommand(procedure, connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter holderParam = new SqlParameter
            {
                ParameterName = "@holder",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = holder,
            };
            command.Parameters.Add(holderParam);

            if (balance is not null)
            {
                wallet.Balance = balance;
                SqlParameter balanceParam = new SqlParameter("@balance", wallet.Balance);
                command.Parameters.Add(balanceParam);
            }

            connection.Open();
            var rowsEffected = command.ExecuteNonQuery();
            if (rowsEffected > 0)
               Console.WriteLine($"{rowsEffected} Rows Effected.");
            else
               Console.WriteLine("THIS WALLET IS NOT FOUND!");
           
            connection.Close();
        }
        static void WidthdrawDepositUsingTransaction(SqlConnection connection, string holder, decimal depositAmount, decimal withdrawAmount)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

            connection.Open();
            SqlTransaction sqlTransaction = connection.BeginTransaction();
            command.Transaction = sqlTransaction;

            try
            {
                 SqlParameter holderParam = new SqlParameter("@holder", holder);
                 SqlParameter depositParam = new SqlParameter($"@deposit", depositAmount);
                 SqlParameter withdrawParam = new SqlParameter($"@withdraw", withdrawAmount);

                 command.Parameters.AddRange(new SqlParameter[]{ holderParam, depositParam, withdrawParam });
                 if (depositAmount > 0)
                 {
                     command.CommandText = $"UPDATE WALLET SET balance += @deposit WHERE holder = @holder";
                     command.ExecuteNonQuery();
                 }
                 else
                     Console.WriteLine("INVALID DEPOSIT AMOUNT!");
           
                command.CommandText = $"SELECT balance FROM Wallet WHERE holder = @holder";
                decimal currenctBalance = (decimal) command.ExecuteScalar();
                if (currenctBalance >= withdrawAmount)
                {
                    command.CommandText = $"UPDATE WALLET SET balance -= @withdraw WHERE holder = @holder";
                    command.ExecuteNonQuery();
                }
                else
                   Console.WriteLine("YOUR BALANCE IS NOT ENOUGH TO WITHDRAW OPERATION!");
                   
                sqlTransaction.Commit();
                
                
            }
            catch
            {
                sqlTransaction.Rollback();
            }
            finally
            {
                connection.Close();
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("[1] Read All Wallets");
            Console.WriteLine("[2] Read All Wallets (Disconnected Mode)");
            Console.WriteLine("[3] Insert New Wallet");
            Console.WriteLine("[4] Insert And Get ID");
            Console.WriteLine("[5] Insert Using Stored Procedure");
            Console.WriteLine("[6] Update a Wallet");
            Console.WriteLine("[7] Delete a Wallet");
            Console.WriteLine("[8] Deposit And Withdraw");
        }

        static string GetWalletHolder(string prompt = "Enter Wallet Holder: ")
        {
            string holder;
            Console.Write(prompt);
            while (string.IsNullOrEmpty(holder = Console.ReadLine()!))
                Console.Write(prompt);
            return holder;
        }

        static decimal GetBalance(string prompt = "Enter Balance: ")
        {
            decimal balance;
            Console.Write(prompt);
            while (!decimal.TryParse(Console.ReadLine(), out balance))
                Console.Write(prompt);
            return balance;
        }
    }

}
