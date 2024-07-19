


using System;
using System.Data;
using System.Data.SqlClient;

class Account
{
    static void Main()
    {

        string connectionString = "Data Source=DESKTOP-TIC5DM4\\SQLEXPRESS;database=TABLE_NAME;integrated security=SSPI";

        PerformTransaction(connectionString);
    }

    static void PerformTransaction(string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                // Insert into Account_Details
                string insertAccountDetails = "INSERT INTO Account_Details (accountId, Account_type, Account_Number, Available_Balance) VALUES (@accountId, @accountType, @accountNumber, @availableBalance)";
                using (SqlCommand cmd = new SqlCommand(insertAccountDetails, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@accountId", 1);
                    cmd.Parameters.AddWithValue("@accountType", "Savings");
                    cmd.Parameters.AddWithValue("@accountNumber", "123456789");
                    cmd.Parameters.AddWithValue("@availableBalance", 1000.00);

                    cmd.ExecuteNonQuery();
                }

                // Insert into Credit_History
                string insertCreditHistory = "INSERT INTO Credit_History (id, accountnumber, Balance_Credit) VALUES (@id, @accountNumber, @balanceCredit)";
                using (SqlCommand cmd = new SqlCommand(insertCreditHistory, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@id", 1);
                    cmd.Parameters.AddWithValue("@accountNumber", "123456789");
                    cmd.Parameters.AddWithValue("@balanceCredit", 500.00);
                    

                    cmd.ExecuteNonQuery();
                }

                // Insert into Debit_History
                string insertDebitHistory = "INSERT INTO Debit_History (id, accountnumber, Balance_Debit) VALUES (@id, @accountNumber, @balanceDebit)";
                using (SqlCommand cmd = new SqlCommand(insertDebitHistory, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@id", 1);
                    cmd.Parameters.AddWithValue("@accountNumber", "123456789");
                    cmd.Parameters.AddWithValue("@balanceDebit", 200.00);
                

                    cmd.ExecuteNonQuery();
                }

                // Commit the transaction
                transaction.Commit();
                Console.WriteLine("Transaction committed successfully.");
            }
            catch (Exception ex)
            {
                // Rollback the transaction in case of an error
                try
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction rolled back.");
                }
                catch (Exception rollbackEx)
                {
                    Console.WriteLine("An error occurred during rollback: " + rollbackEx.Message);
                }

                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection closed.");
            }
        }
    }
}



