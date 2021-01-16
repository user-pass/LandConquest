﻿using LandConquestDB.Entities;
using System;
using System.Data.SqlClient;


namespace LandConquestDB.Models
{
    public class UserModel
    {
        public static User UserAuthorisation(string login, string pass)
        {
            User user = new User();

            String query = "SELECT * FROM dbo.UserData WHERE user_login = @user_login AND user_pass = @user_pass";

            var command = new SqlCommand(query, DbContext.GetConnection());
            command.Parameters.AddWithValue("@user_login", login);
            command.Parameters.AddWithValue("@user_pass", pass);

            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    var userId = reader.GetOrdinal("user_id");
                    var userLogin = reader.GetOrdinal("user_login");
                    var userEmail = reader.GetOrdinal("user_email");
                    var userPass = reader.GetOrdinal("user_pass");
                    while (reader.Read())
                    {
                        user.UserId = reader.GetString(userId);
                        user.UserLogin = reader.GetString(userLogin);
                        user.UserEmail = reader.GetString(userEmail);
                        user.UserPass = reader.GetString(userPass);

                    }
                }
            }
            return user;
        }

        public static int CreateUser(string login, string email, string pass, string userId)
        {
            String userQuery = "INSERT INTO dbo.UserData (user_id,user_login,user_email,user_pass) VALUES (@user_id, @user_login, @user_email, @user_pass)";
            var userCommand = new SqlCommand(userQuery, DbContext.GetConnection());


            userCommand.Parameters.AddWithValue("@user_id", userId);
            userCommand.Parameters.AddWithValue("@user_login", login);
            userCommand.Parameters.AddWithValue("@user_email", email);
            userCommand.Parameters.AddWithValue("@user_pass", pass);

            int userResult = userCommand.ExecuteNonQuery();
            return userResult;
        }

        public static User GetUserInfo(string user_id)
        {
            User user = new User();

            String query = "SELECT * FROM dbo.UserData WHERE user_id = @user_id";

            var command = new SqlCommand(query, DbContext.GetConnection());
            command.Parameters.AddWithValue("@user_id", user_id);

            using (var reader = command.ExecuteReader())
            {
                var userId = reader.GetOrdinal("user_id");
                var userLogin = reader.GetOrdinal("user_login");
                var userEmail = reader.GetOrdinal("user_email");
                var userPass = reader.GetOrdinal("user_pass");
                while (reader.Read())
                {
                    user.UserId = reader.GetString(userId);
                    user.UserLogin = reader.GetString(userLogin);
                    user.UserEmail = reader.GetString(userEmail);
                    user.UserPass = reader.GetString(userPass);
                }
            }
            return user;
        }

        public static void UpdateUserEmail(string userId, string newUserEmail)
        {
            String userQuery = "UPDATE dbo.UserData SET user_email = @user_email WHERE user_id = @user_id";
            var userCommand = new SqlCommand(userQuery, DbContext.GetConnection());


            userCommand.Parameters.AddWithValue("@user_id", userId);
            userCommand.Parameters.AddWithValue("@user_email", newUserEmail);

            userCommand.ExecuteNonQuery();
        }

        public static void UpdateUserPass(string userId, string newUserPass)
        {
            String userQuery = "UPDATE dbo.UserData SET user_pass = @user_pass WHERE user_id = @user_id";
            var userCommand = new SqlCommand(userQuery, DbContext.GetConnection());


            userCommand.Parameters.AddWithValue("@user_id", userId);
            userCommand.Parameters.AddWithValue("@user_pass", newUserPass);

            userCommand.ExecuteNonQuery();
        }

        public static bool ValidateUserByLogin(string user_login)
        {
            String query = "SELECT * FROM dbo.UserData WHERE user_login = @user_login";

            var command = new SqlCommand(query, DbContext.GetConnection());
            command.Parameters.AddWithValue("@user_login", user_login);

            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool ValidateUserByEmail(string user_email)
        {
            String query = "SELECT * FROM dbo.UserData WHERE user_email = @user_email";

            var command = new SqlCommand(query, DbContext.GetConnection());
            command.Parameters.AddWithValue("@user_email", user_email);

            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}